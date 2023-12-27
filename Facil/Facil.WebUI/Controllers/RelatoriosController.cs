using Facil.Aplicacao.Interfaces;
using Facil.Aplicacao.Services;
using Facil.WebUI.ViewModels;
using FastReport.Data;
using FastReport.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Facil.WebUI.Controllers;

[Authorize]
public class RelatoriosController : Controller
{
    private readonly IWebHostEnvironment _environment;
    private readonly IClienteService _clienteService;
    private readonly IAppointmentService _atendimentoService;
        
    public RelatoriosController(IWebHostEnvironment environment, IClienteService clienteService, IAppointmentService atendimentoService)
    {
        _environment = environment;
        _clienteService = clienteService;
        _atendimentoService = atendimentoService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> Atendimentos()
    {
        ReportViewModel model = await Filtros("DataAtendimento");
        //exibirmos o relatorio
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Atendimentos(Guid clienteId, DateTime dataInicio, DateTime dataFim)
    {
        //criamos uma instancia do objeto webreport
        var model = new ReportViewModel();

        model.ClienteId = clienteId;
        model.DataInicio = dataInicio;
        model.DataFim = dataFim;

        model.FiltroData = "DataAtendimento";

        var arquivo = "Listar_Atendimentos.frx";


        var webReport = new WebReport();

        if (clienteId != Guid.Empty)
            arquivo = "Listar_AtendimentosCliente.frx";

       
        //obtemos os dados

       if (dataFim == DateTime.MinValue)
            model.DataFim = DateTime.MaxValue;

        //GetVendasVendedor -> Guid VendedorId, DateTime DataInicio, DateTime DataFinal
        //var listaVendas = await _vendaService.GetTodasVendas(model.VendedorId, model.EmpresaId, model.DataInicio, model.DataFim, model.FiltroData, model.Tipo);

        var listaAtendimentos = await _atendimentoService.GetTodosAtendimentos(model.ClienteId, model.DataInicio, model.DataFim, model.FiltroData);

        await PopularDropDown();

        await GerarRelatorio(model, webReport, arquivo, listaAtendimentos);

        //exibirmos o relatorio
        return View(model);

    }




    private async Task<ReportViewModel> Filtros(string filtro)
    {
        var webReport = new WebReport();

        //criamos uma instancia do objeto webreport
        var model = new ReportViewModel();


        model.ClienteId = Guid.Empty;
        //model.AtendimentoId = Guid.Empty;

        var hoje = DateTime.UtcNow;

        var primeiroDia = new DateTime(hoje.Year, hoje.Month - 1, 1);
        var diasMes = DateTime.DaysInMonth(hoje.Year, hoje.Month - 1);
        var ultimoDia = new DateTime(hoje.Year, hoje.Month - 1, diasMes);

        model.DataInicio = primeiroDia;
        model.DataFim = ultimoDia;

        model.FiltroData = filtro;

        await PopularDropDown();


        model.WebReport = webReport;
        //exibirmos o relatorio
        return model;
    }

    private async Task PopularDropDown()
    {
        ViewBag.ClienteId =  new SelectList(await _clienteService.GetClientes(), "ID", "Nome");
    }

    private async Task GerarRelatorio(ReportViewModel model, WebReport webReport, string arquivo, 
        IEnumerable<Aplicacao.DTOs.AtendimentoDTO> listaAtendimentos)
    {

        // Obtemos uma instância do objeto MsSqlDataConnection
        // e definimos a string de conexão para o banco de dados nele
        var mssqlDataConnection = new MsSqlDataConnection();

        webReport.Report.Dictionary.Connections.Add(mssqlDataConnection);

        //carregamos o relatório criado na pasta reports
        webReport.Report.Load(Path.Combine(_environment.ContentRootPath, "wwwroot/reports", arquivo));

        // Configuração do formato de data pt-BR


        var atendimentos = HelperFastReport.GetTable(listaAtendimentos, "Atendimentos");

        var lista = await _clienteService.GetClientes();
        var clientes = HelperFastReport.GetTable(lista, "Clientes");

        //registramos as fontes de dados 
        webReport.Report.RegisterData(atendimentos, "Atendimentos");
        webReport.Report.RegisterData(clientes, "Clientes");       

        webReport.Report.SetParameterValue("DataInicio", model.DataInicio);
        webReport.Report.SetParameterValue("DataFim", model.DataFim);

        model.WebReport = webReport;
    }

}
