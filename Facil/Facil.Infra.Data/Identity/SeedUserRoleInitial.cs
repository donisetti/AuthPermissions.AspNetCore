using Facil.Dominio.Account;
using Facil.Dominio.Entidades.DadosPessoa;
using Facil.Infra.Data.Contexto;
using Microsoft.AspNetCore.Identity;
using System.Globalization;

namespace Facil.Infra.Data.Identity;


public class SeedUserRoleInitial : ISeedUserRoleInitial
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly ApplicationDbContext _applicationDbContext;

    public SeedUserRoleInitial(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext applicationDbContext)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _applicationDbContext = applicationDbContext;
    }

    public void SeedUsers()
    {
        if (_userManager.FindByEmailAsync("master@vasis.com").Result == null)
        {
            ApplicationUser user = new ApplicationUser();
            user.UserName = "master@vasis.com";
            user.Email = "master@vasis.com";
            user.NormalizedUserName = "MASTER@VASIS.COM";
            user.NormalizedEmail = "MASTER@VASIS.COM";
            user.EmailConfirmed = true;
            user.LockoutEnabled = false;
            user.SecurityStamp = Guid.NewGuid().ToString();

            IdentityResult result = _userManager.CreateAsync(user, "Val@2022*").Result;

            if (result.Succeeded)
            {
                _userManager.AddToRoleAsync(user, "Admin").Wait();
            }
        }

        if (_userManager.FindByEmailAsync("donisetti@msn.com").Result == null)
        {
            ApplicationUser user = new ApplicationUser();
            user.UserName = "donisetti@msn.com";
            user.Email = "donisetti@msn.com";
            user.NormalizedUserName = "DONISETTI@MSN.COM";
            user.NormalizedEmail = "DONISETTI@MSN.COM";
            user.EmailConfirmed = true;
            user.LockoutEnabled = false;
            user.SecurityStamp = Guid.NewGuid().ToString();

            IdentityResult result = _userManager.CreateAsync(user, "Numsey#2023").Result;

            if (result.Succeeded)
            {
                _userManager.AddToRoleAsync(user, "User").Wait();
            }
        }

    }

    public void SeedRoles()
    {
        try
        {
            if (!_roleManager.RoleExistsAsync("User").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "User";
                role.NormalizedName = "USER";
                IdentityResult roleResult = _roleManager.CreateAsync(role).Result;
            }

            if (!_roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Admin";
                role.NormalizedName = "ADMIN";
                IdentityResult roleResult = _roleManager.CreateAsync(role).Result;
            }

            if (!_roleManager.RoleExistsAsync("Vendedor").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Vendedor";
                role.NormalizedName = "VENDEDOR";
                IdentityResult roleResult = _roleManager.CreateAsync(role).Result;
            }
        }
        catch (Exception erro)
        {
            var msg = erro.Message;


        }


    }




   
   
  
    public DateTime? UltimoDiaMes(DateTime date)
    {
        int lastDay = DateTime.DaysInMonth(date.Year, date.Month);
        return new DateTime(date.Year, date.Month, lastDay);
    }





}
