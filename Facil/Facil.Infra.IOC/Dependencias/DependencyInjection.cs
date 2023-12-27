using Facil.Aplicacao.Interfaces;
using Facil.Aplicacao.Mappings;
using Facil.Aplicacao.Services;
using Facil.Dominio.Account;
using Facil.Dominio.Interfaces;
using Facil.Infra.Data.Contexto;
using Facil.Infra.Data.Identity;
using Facil.Infra.Data.Repositories;
using FastReport.Data;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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

        return services;
    }
}
