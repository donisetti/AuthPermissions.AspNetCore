using AuthPermissions.SupportCode.DownStatusCode;
using AuthPermissions;
using AuthPermissions.AspNetCore;
using AuthPermissions.AspNetCore.Services;
using AuthPermissions.AspNetCore.StartupServices;
using AuthPermissions.BaseCode.SetupCode;

using Facil.Aplicacao.Interfaces;
using Facil.Aplicacao.Mappings;
using Facil.Aplicacao.Services;
using Facil.Dominio.Account;
using Facil.Dominio.Interfaces;
using Facil.Infra.Data.Contexto;
using Facil.Infra.Data.Identity;
using Facil.Infra.Data.Repositories;
using Facil.Infra.IOC.PermissionsCode;
using FastReport.Data;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Example4.ShopCode.EfCoreCode;
using RunMethodsSequentially;
using Example4.ShopCode.AppStart;
using Net.DistributedFileStoreCache;

namespace Facil.Infra.IOC.Dependencias;


public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
        IConfiguration configuration)
    {

        string connectionString = Environment.GetEnvironmentVariable("DATABASE_CONNECTION_STRING");

        if (connectionString != null)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
      options.UseSqlServer(connectionString, b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

        }
        else
        {
            services.AddDbContext<ApplicationDbContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"
            ), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
        }

        FastReport.Utils.RegisteredObjects.AddConnection(typeof(MsSqlDataConnection));

        // Adiciona a configuração do appsettings.json ao projeto
        //var appSettings = configuration.GetSection("Sistema");
        //services.Configure<Sistema>(appSettings);

        services.AddIdentity<ApplicationUser, IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();

        services.ConfigureApplicationCookie(options =>
                 options.AccessDeniedPath = "/Account/Login");

        services.AddHttpClient();

        services.AddScoped<IClienteRepository, ClienteRepositorio>();
        services.AddScoped<IFuncionarioRepository, FuncionarioRepositorio>();

        services.AddScoped<IClienteService, ClienteService>();
        services.AddScoped<IFuncionarioService, FuncionarioService>();

        services.AddScoped<IAtendimentoRepository, AtendimentoRepositorio>();
        services.AddScoped<IAppointmentService, AtendimentoService>();

        services.AddScoped<IAgendamentoRepository, AgendamentoRepositorio>();
        services.AddScoped<IAgendamentoService, AgendamentoService>();



        services.AddScoped<IAuthenticate, AuthenticateService>();
        services.AddScoped<ISeedUserRoleInitial, SeedUserRoleInitial>();

        services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

        var myhandlers = AppDomain.CurrentDomain.Load("Facil.Aplicacao");
        services.AddMediatR(myhandlers);


        services.ConfigureApplicationCookie(options =>
        {
            // isso fará com que todos os usuários conectados tenham suas reivindicações atualizadas se elas forem antigas
            // OBSERVAÇÃO: você deve registrar a reivindicação AddGlobalChangeTimeClaim via RegisterAddClaimToUser

            options.Events.OnValidatePrincipal = SomethingChangedCookieEvent.UpdateClaimsIfSomethingChangesAsync;
        });



        services.RegisterAuthPermissions<Permissions>(options =>
        {
            options.TenantType = TenantTypes.HierarchicalTenant;
            //options.PathToFolderToLock = .Environment.WebRootPath;
        })
            //NOTE: This uses the same database as the individual accounts DB
            .UsingEfCoreSqlServer(connectionString)
            .IndividualAccountsAuthentication()
            .RegisterAddClaimToUser<AddGlobalChangeTimeClaim>()
            .RegisterTenantChangeService<RetailTenantChangeService>()
            .AddRolesPermissionsIfEmpty(AppAuthSetupData.RolesDefinition)
            .AddTenantsIfEmpty(AppAuthSetupData.TenantDefinition)
            .AddAuthUsersIfEmpty(AppAuthSetupData.UsersRolesDefinition)
            .RegisterFindUserInfoService<IndividualAccountUserLookup>()
            .RegisterAuthenticationProviderReader<SyncIndividualAccountUsers>()
            .AddSuperUserToIndividualAccounts()
            .SetupAspNetCoreAndDatabase(options =>
            {
                //Migrate individual account database
                options.RegisterServiceToRunInJob<StartupServiceMigrateAnyDbContext<ApplicationDbContext>>();

                //Add demo users to the database
                //options.RegisterServiceToRunInJob<StartupServicesIndividualAccountsAddDemoUsers>();

                //Migrate the application part of the database
                //options.RegisterServiceToRunInJob<StartupServiceMigrateAnyDbContext<RetailDbContext>>();

                //This seeds the invoice database (if empty)
                options.RegisterServiceToRunInJob<StartupServiceServiceSeedRetailDatabase>();
            });


        // Isso é usado para definir a Status do aplicativo como "Down" e o locatário como "Down",
        // além de tratar uma alteração de DataKey do locatário que requer uma atualização das reivindicações do usuário

        //services.AddDistributedFileStoreCache(options =>
        //{
        //    options.WhichVersion = FileStoreCacheVersions.Class;
        //    //I override the the default first part of the FileStore cache file because there are many example apps in this repo
        //    options.FirstPartOfCacheFileName = "Example4CacheFileStore";
        //}, Environment);





        return services;
    }
}
