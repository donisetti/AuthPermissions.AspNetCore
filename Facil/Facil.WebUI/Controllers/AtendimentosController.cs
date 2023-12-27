using Facil.Aplicacao.DTOs;
using Facil.Aplicacao.Interfaces;
using Facil.Aplicacao.Services;
using FastReport.Data;
using FastReport.Export.PdfSimple;
using FastReport.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Facil.WebUI.Controllers
{
    [Authorize]
    public class AtendimentosController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly IAppointmentService _atendimentoService;
        private readonly IClienteService _clienteService;

        public AtendimentosController(IWebHostEnvironment environment, IAppointmentService atendimentoService, IClienteService clienteService)
        {
            _environment = environment;
            _atendimentoService = atendimentoService;
            _clienteService = clienteService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var atendimento = await _atendimentoService.GetAtendimentos();
            return View(atendimento);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var model = new AtendimentoDTO();
            //model.ID = Guid.NewGuid();
            //model.DataAtendimento = DateTime.UtcNow;
            
            await PopularDropDown();
            return View(model);
        }

        private async Task PopularDropDown()
        {
            ViewBag.ClienteId = new SelectList(await _clienteService.GetClientes(), "ID", "Nome");
        }

        [HttpPost]
        public async Task<IActionResult> Create(AtendimentoDTO atendimentoDto)
        {
            if (ModelState.IsValid)
            {
                //atendimentoDto.ID = Guid.NewGuid();
                await _atendimentoService.Add(atendimentoDto);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                await PopularDropDown();
            }
            return View(atendimentoDto);
        }


        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            if (id == Guid.Empty) return NotFound();

            var atendimentoDto = await _atendimentoService.GetById(id);

            if (atendimentoDto == null) return NotFound();
            await PopularDropDown();
            return View(atendimentoDto);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AtendimentoDTO atendimentoDto)
        {
            if (ModelState.IsValid)
            {
                await _atendimentoService.Update(atendimentoDto);
                return RedirectToAction(nameof(Index));
            }
            
            return View(atendimentoDto);
        }

        //[Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty)
                return NotFound();

            var clienteDto = await _atendimentoService.GetById(id);

            if (clienteDto == null) return NotFound();

            return View(clienteDto);
        }

        [HttpPost(), ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _atendimentoService.Remove(id);
            return RedirectToAction("Index");
        }

        [Route("Atendimentos/Listar")]
        public async Task<IActionResult> Listar()
        {
            //criamos uma instancia do objeto webreport
            var webReport = new WebReport();

            // Obtemos uma instância do objeto MsSqlDataConnection
            // e definimos a string de conexão para o banco de dados nele
            var mssqlDataConnection = new MsSqlDataConnection();

            webReport.Report.Dictionary.Connections.Add(mssqlDataConnection);

            //carregamos o relatório criado na pasta reports
            webReport.Report.Load(Path.Combine(_environment.ContentRootPath, "wwwroot/reports", "Listar_Atendimentos.frx"));

            //obtemos os dados para atendimentos
            var listaCliente = await _clienteService.GetClientes();
            var listaAtendimento = await _atendimentoService.GetAtendimentos();

            var clientes = HelperFastReport.GetTable(listaCliente, "Clientes");
            var atendimentos = HelperFastReport.GetTable(listaAtendimento, "Atendimentos");

            //registramos as fontes de dados 
            webReport.Report.RegisterData(clientes, "Clientes");
            webReport.Report.RegisterData(atendimentos, "Atendimentos");

            //exibirmos o relatorio
            return View(webReport);
        }


        [Route("Atendimentos/BaixarPdf")]
        public async Task<IActionResult> BaixarPdf()
        {
            //criamos uma instancia do objeto webreport
            var webReport = new WebReport();

            // Obtemos uma instância do objeto MsSqlDataConnection
            // e definimos a string de conexão para o banco de dados nele
            var mssqlDataConnection = new MsSqlDataConnection();

            webReport.Report.Dictionary.Connections.Add(mssqlDataConnection);

            //carregamos o relatório criado na pasta reports
            webReport.Report.Load(Path.Combine(_environment.ContentRootPath, "wwwroot/reports", "Listar_Atendimentos.frx"));

            //obtemos os dados para empresas
            var lista = await _atendimentoService.GetAtendimentos();

            var atendimentos = HelperFastReport.GetTable(lista, "Atendimentos");

            //registramos as fontes de dados 
            webReport.Report.RegisterData(atendimentos, "Atendimentos");

            webReport.Report.Prepare();

            Stream stream = new MemoryStream();
            webReport.Report.Export(new PDFSimpleExport(), stream);
            stream.Position = 0;

            // retorna o stream no navegador
            return File(stream, "application/zip", "Listar_Atendimentos.pdf");
        }
    }
}
