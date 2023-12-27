using Facil.Dominio.Entidades;
using Facil.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Facil.WebUI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly Sistema _app;
        private readonly IWebHostEnvironment _environment;
        private readonly IConfiguration _configuration;

        private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController(IWebHostEnvironment environment, IConfiguration configuration)
        {
            _environment = environment;
            _configuration = configuration;

            var conexao = _configuration.GetConnectionString("DefaultConnection");

            var versao = _configuration.GetValue<string>("Sistema:Versao");
            var data = _configuration.GetValue<string>("Sistema:Data");

            var ambiente = _configuration.GetValue<string>("Sistema:Ambiente");

            if (!_environment.IsDevelopment())
            {
                ambiente = "Dev";
            }
            _app = new Sistema(versao, data, ambiente, conexao);

        }

        public IActionResult Index()
        {
            ViewBag.Versao = _app.Versao;
            ViewBag.Data = _app.Data;
            ViewBag.Ambiente = _app.Ambiente;
            //ViewBag.Conexao = _app.Conexao;
            var _conexao = _app.Conexao.Split(";");
            ViewBag.Servidor = _conexao[0];
            ViewBag.BancoDados = _conexao[1];

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}