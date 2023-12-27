using Facil.Dominio.Account;
using Facil.Infra.Data.Identity;
using Facil.WebUI.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Facil.WebUI.Controllers.Identity;

public class AccountController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly IAuthenticate _authentication;

    //public AccountController(IAuthenticate authentication)
    //{
    //    _authentication = authentication;
    //}

    public AccountController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IAuthenticate authentication)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _authentication = authentication;
    }

    [HttpGet]
    public IActionResult Login(string returnUrl)
    {
        return View(new LoginViewModel()
        {
            ReturnUrl = returnUrl
        });
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (string.IsNullOrEmpty(model.Email) || string.IsNullOrEmpty(model.Password))
        {
            return View(model);
        }

        var result = await _authentication.Authenticate(model.Email, model.Password);

        if (result)
        {
            if (string.IsNullOrEmpty(model.ReturnUrl))
            {
                return RedirectToAction("Index", "Home");
            }
            return Redirect(model.ReturnUrl);
        }
        else
        {
            ModelState.AddModelError(string.Empty, "Tentativa de login inválida. (a senha deve ser forte).");
            return View(model);
        }
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        var result = await _authentication.RegisterUser(model.Email, model.Password);

        if (result)
        {
            ApplicationUser user = await _userManager.FindByEmailAsync(model.Email);

            _userManager.AddToRoleAsync(user, "User").Wait();

            return Redirect("/");
        }
        else
        {
            ModelState.AddModelError(string.Empty, "Tentativa de cadastro inválida (a senha deve ser forte.");
            return View(model);
        }
    }

    public async Task<IActionResult> Logout()
    {
        await _authentication.Logout();
        return Redirect("/Account/Login");
    }
}
