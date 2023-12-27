using ElmahCore;
using Facil.Aplicacao.DTOs;
using Facil.Aplicacao.Interfaces;
using Facil.Aplicacao.Services;
using Facil.WebUI.Models;
using FastReport.Data;
using FastReport.Export.PdfSimple;
using FastReport.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Facil.WebUI.Controllers;

public class FuncionariosController : Controller
{
    private readonly IWebHostEnvironment _environment;
    private readonly IFuncionarioService _funcionarioService;
    private readonly IHttpClientFactory _httpClientFactory;

    public FuncionariosController(IWebHostEnvironment environment, IFuncionarioService funcionarioService, IHttpClientFactory httpClientFactory)
    {
        _environment = environment;
        _funcionarioService = funcionarioService;
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> Index()
    {
        var funcionarios = await _funcionarioService.GetFuncionarios();

        return View(funcionarios);
    }

    [HttpGet]
    public async Task<IActionResult> Create()
    {
        await PopularDropDown();

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(FuncionarioDTO funcionarioDTO)
    {
        if (ModelState.IsValid)
        {
            await _funcionarioService.Add(funcionarioDTO);
            return RedirectToAction(nameof(Index));
        }
        else
        {

            var errors = ModelState.Values.Where(i => i.Errors.Count > 0);


            await PopularDropDown();

        }
        return View(funcionarioDTO);
    }

    [HttpGet]
    public async Task<IActionResult> Edit(Guid id)
    {
        if (id == Guid.Empty) return NotFound();
        var funcionarioDTO = await _funcionarioService.GetById(id);

        if (funcionarioDTO == null) return NotFound();

        //await PopularDropDown();

        return View(funcionarioDTO);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(FuncionarioDTO funcionarioDTO)
    {
        if (ModelState.IsValid)
        {
            await _funcionarioService.Update(funcionarioDTO);
            return RedirectToAction(nameof(Index));
        }
        else
        {
            //await PopularDropDown();
        }
        return View(funcionarioDTO);
    }

    //[Authorize(Roles = "Admin")]
    [HttpGet]
    public async Task<IActionResult> Delete(Guid id)
    {
        if (id == Guid.Empty)
            return NotFound();

        var funcionarioDTO = await _funcionarioService.GetById(id);

        if (funcionarioDTO == null) return NotFound();

        return View(funcionarioDTO);
    }

    [HttpPost(), ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        await _funcionarioService.Remove(id);
        return RedirectToAction("Index");
    }

    [Route("Funcionarios/Listar")]
    public async Task<IActionResult> Listar()
    {
        //criamos uma instancia do objeto webreport
        var webReport = new WebReport();

        // Obtemos uma instância do objeto MsSqlDataConnection
        // e definimos a string de conexão para o banco de dados nele
        var mssqlDataConnection = new MsSqlDataConnection();

        webReport.Report.Dictionary.Connections.Add(mssqlDataConnection);

        //carregamos o relatório criado na pasta reports
        webReport.Report.Load(Path.Combine(_environment.ContentRootPath, "wwwroot/reports", "Listar_Funcionarios.frx"));

        //obtemos os dados para empresas
        var lista = await _funcionarioService.GetFuncionarios();

        var funcionarios = HelperFastReport.GetTable(lista, "Funcionarios");

        //registramos as fontes de dados 
        webReport.Report.RegisterData(funcionarios, "Funcionarios");

        //exibirmos o relatorio
        return View(webReport);
    }


    [Route("Funcionarios/BaixarPdf")]
    public async Task<IActionResult> BaixarPdf()
    {
        //criamos uma instancia do objeto webreport
        var webReport = new WebReport();

        // Obtemos uma instância do objeto MsSqlDataConnection
        // e definimos a string de conexão para o banco de dados nele
        var mssqlDataConnection = new MsSqlDataConnection();

        webReport.Report.Dictionary.Connections.Add(mssqlDataConnection);

        //carregamos o relatório criado na pasta reports
        webReport.Report.Load(Path.Combine(_environment.ContentRootPath, "wwwroot/reports", "Listar_Funcionarios.frx"));

        //obtemos os dados para empresas
        var lista = await _funcionarioService.GetFuncionarios();

        var funcionarios = HelperFastReport.GetTable(lista, "Funcionarios");

        //registramos as fontes de dados 
        webReport.Report.RegisterData(funcionarios, "Funcionarios");

        webReport.Report.Prepare();

        Stream stream = new MemoryStream();
        webReport.Report.Export(new PDFSimpleExport(), stream);
        stream.Position = 0;

        // retorna o stream no navegador
        return File(stream, "application/zip", "Listagem_Funcionarios.pdf");

    }


    private async Task PopularDropDown(string uf = "PR|SP|MS|SC|RS|")
    {

        var httpClient = _httpClientFactory.CreateClient();


        try
        {
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
        catch (Exception erro)
        {
            var msg = erro.Message;

            
        }

     



       


    }


}
