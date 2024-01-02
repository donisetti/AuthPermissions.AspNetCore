using ElmahCore.Mvc;
using ElmahCore;
using Facil.Infra.IOC.Dependencias;
using Facil.Dominio.Account;

// >>>>>>>>>>>>>>>>>>>>>>


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration);


// Configurar o Elmah
builder.Services.AddElmah<XmlFileErrorLog>(options =>
{
    options.LogPath = "~/log";

});

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseElmahExceptionPage();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    //app.UseExceptionHandler("/Home/Error/");

    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

//if (!app.Environment.IsProduction())
//{
//    var conexao = builder.Configuration.GetConnectionString("DefaultConnection");

//    var versao = builder.Configuration.GetValue<string>("Sistema:Versao");
//    var data = builder.Configuration.GetValue<string>("Sistema:Data");

//    var ambiente = builder.Configuration.GetValue<string>("Sistema:Ambiente");


//}

app.UseHttpsRedirection();

var supportedCultures = new[] { "pt-BR", "en-US", "it" };

var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture(supportedCultures[0])
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

app.UseRequestLocalization(localizationOptions);

app.UseStaticFiles();

app.UseRouting();

SeedUserRoles(app);


app.UseAuthentication();
app.UseAuthorization();

app.UseElmah();
app.UseFastReport();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
     name: "areas",
     pattern: "{area:exists}/{controller=Admin}/{action=Index}/{id?}");


    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});
app.Run();

void SeedUserRoles(IApplicationBuilder app)
{
    using (var serviceScope = app.ApplicationServices.CreateScope())
    {
        var seed = serviceScope.ServiceProvider
                               .GetService<ISeedUserRoleInitial>();

        seed.SeedRoles();
        seed.SeedUsers();
    }
}
