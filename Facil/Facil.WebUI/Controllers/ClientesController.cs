using Facil.Aplicacao.DTOs;
using Facil.Aplicacao.Interfaces;
using Facil.Aplicacao.Services;
using Facil.WebUI.Models;
using FastReport.Data;
using FastReport.Export.PdfSimple;
using FastReport.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Facil.WebUI.Controllers;

[Authorize]
public class ClientesController : Controller
{
    private readonly IWebHostEnvironment _environment;
    private readonly IClienteService _clienteService;
    private readonly IHttpClientFactory _httpClientFactory;

    public ClientesController(IWebHostEnvironment environment, IClienteService clienteService, IHttpClientFactory httpClientFactory)
    {
        _environment = environment;
        _clienteService = clienteService;
        _httpClientFactory = httpClientFactory;
    }   

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var clientes = await _clienteService.GetClientes();
        return View(clientes);
    }

    [HttpGet]
    public async Task<IActionResult> Create()
    {
        //await PopularDropDown();

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(ClienteDTO clienteDto)
    {
        if (ModelState.IsValid)
        {
            await _clienteService.Add(clienteDto);
            return RedirectToAction(nameof(Index));
        }
        else
        {
            //await PopularDropDown();
        }
        return View(clienteDto);
    }

    [HttpGet]
    public async Task<IActionResult> Edit(Guid id)
    {
        if (id == Guid.Empty) return NotFound();
        var clienteDto = await _clienteService.GetById(id);

        if (clienteDto == null) return NotFound();

        //await PopularDropDown();

        return View(clienteDto);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(ClienteDTO clienteDto)
    {
        if (ModelState.IsValid)
        {
            await _clienteService.Update(clienteDto);
            return RedirectToAction(nameof(Index));
        }
        else
        {
            //await PopularDropDown();
        }
        return View(clienteDto);
    }

    //[Authorize(Roles = "Admin")]
    [HttpGet]
    public async Task<IActionResult> Delete(Guid id)
    {
        if (id == Guid.Empty)
            return NotFound();

        var clienteDto = await _clienteService.GetById(id);

        if (clienteDto == null) return NotFound();

        return View(clienteDto);
    }

    [HttpPost(), ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        await _clienteService.Remove(id);
        return RedirectToAction("Index");
    }

    [Route("Clientes/Listar")]
    public async Task<IActionResult> Listar()
    {
        //criamos uma instancia do objeto webreport
        var webReport = new WebReport();

        // Obtemos uma instância do objeto MsSqlDataConnection
        // e definimos a string de conexão para o banco de dados nele
        var mssqlDataConnection = new MsSqlDataConnection();

        webReport.Report.Dictionary.Connections.Add(mssqlDataConnection);

        //carregamos o relatório criado na pasta reports
        webReport.Report.Load(Path.Combine(_environment.ContentRootPath, "wwwroot/reports", "Listar_Clientes.frx"));

        //obtemos os dados para empresas
        var lista = await _clienteService.GetClientes();

        var clientes = HelperFastReport.GetTable(lista, "Clientes");

        //registramos as fontes de dados 
        webReport.Report.RegisterData(clientes, "Clientes");

        //exibirmos o relatorio
        return View(webReport);
    }


    [Route("Clientes/BaixarPdf")]
    public async Task<IActionResult> BaixarPdf()
    {
        //criamos uma instancia do objeto webreport
        var webReport = new WebReport();

        // Obtemos uma instância do objeto MsSqlDataConnection
        // e definimos a string de conexão para o banco de dados nele
        var mssqlDataConnection = new MsSqlDataConnection();

        webReport.Report.Dictionary.Connections.Add(mssqlDataConnection);

        //carregamos o relatório criado na pasta reports
        webReport.Report.Load(Path.Combine(_environment.ContentRootPath, "wwwroot/reports", "Listar_Clientes.frx"));

        //obtemos os dados para empresas
        var lista = await _clienteService.GetClientes();

        var clientes = HelperFastReport.GetTable(lista, "Clientes");

        //registramos as fontes de dados 
        webReport.Report.RegisterData(clientes, "Clientes");

        webReport.Report.Prepare();

        Stream stream = new MemoryStream();
        webReport.Report.Export(new PDFSimpleExport(), stream);
        stream.Position = 0;

        // retorna o stream no navegador
        return File(stream, "application/zip", "Listagem_Clientes.pdf");

    }


    private async Task PopularDropDown(string uf = "PR|SP|MS|SC|RS|")
    {

        var httpClient = _httpClientFactory.CreateClient();

        var estados = await httpClient.GetFromJsonAsync<List<Estado>>("https://servicodados.ibge.gov.br/api/v1/localidades/estados/");
        var municipios = await httpClient.GetFromJsonAsync<List<Municipio>>($"https://servicodados.ibge.gov.br/api/v1/localidades/estados/{uf}/municipios");

        if (estados != null)
        {
            ViewBag.Estados = new SelectList(estados, "Sigla", "Nome");
        }

        if (municipios != null)
        {
            ViewBag.Municipios = new SelectList(municipios, "Nome", "Nome");
        }


    }

}
