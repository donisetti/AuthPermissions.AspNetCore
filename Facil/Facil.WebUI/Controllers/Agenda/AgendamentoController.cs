using Facil.Aplicacao.DTOs;
using Facil.Aplicacao.Interfaces;
using Facil.Aplicacao.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Protocol;
using System.Text.Json;

namespace Facil.WebUI.Controllers.Agenda;

public class AgendamentoController : Controller
{
    // Agendamento
    private readonly IWebHostEnvironment _environment;
    private readonly IAgendamentoService _agendamentoService;
    private readonly IClienteService _clienteService;
    private readonly IFuncionarioService _funcionarioService;

    public AgendamentoController(IWebHostEnvironment environment, IAgendamentoService agendamentoService, IClienteService clienteService, IFuncionarioService funcionarioService)
    {
        _environment = environment;
        _agendamentoService = agendamentoService;
        _clienteService = clienteService;
        _funcionarioService = funcionarioService;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var agendamento = await _agendamentoService.Getappointments();
        return View(agendamento);
    }

    public async Task<IActionResult> Agenda(string role)
    {
        ViewBag.Role = role;
        var agendamento = await _agendamentoService.Getappointments();
        ViewBag.Agendamentos = agendamento;

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Novo(AppointmentDTO appointmentDto)
    {
        return await Salvar(appointmentDto);
    }


    [HttpGet]
    public async Task<IActionResult> Create()
    {
        var model = new AppointmentDTO();

        model.Start = DateTime.UtcNow;
        model.End = DateTime.UtcNow.AddMinutes(30);
        model.Color = "Green";


        //model.ID = Guid.NewGuid();
        //model.DataAtendimento = DateTime.UtcNow;

        await PopularDropDown();
        return View(model);
    }

    private async Task PopularDropDown()
    {
        ViewBag.ClienteId = new SelectList(await _clienteService.GetClientes(), "ID", "Nome");
        ViewBag.FuncionarioId = new SelectList(await _funcionarioService.GetFuncionarios(), "ID", "Nome");

        //ViewBag.EventStatus = new SelectList(await _agendamentoService.GetStatus(), "ID", "Nome");
    }

    [HttpPost]
    public async Task<IActionResult> Alterar(AppointmentDTO appointmentDto)
    {
        return await Gravar(appointmentDto);
    }

    [HttpPost]
    public async Task<IActionResult> Create(AppointmentDTO appointmentDto)
    {
        return await Salvar(appointmentDto);
    }

    private async Task<IActionResult> Salvar(AppointmentDTO appointmentDto)
    {
        if (ModelState.IsValid)
        {
            //atendimentoDto.ID = Guid.NewGuid();

            appointmentDto.Color = "Green";


            await _agendamentoService.Add(appointmentDto);
            return RedirectToAction(nameof(Index));
        }
        else
        {
            await PopularDropDown();
        }
        return View(appointmentDto);
    }



    [HttpGet]
    [Route("Agendamento/Novo")]
    public async Task<IActionResult> Create(string eventDate)
    {
      
        var model = new AppointmentDTO();

        DateTime data = DateTime.UtcNow;

        if (eventDate != null)
            data = DateTime.Parse(eventDate);

        model.Start = data;
        model.End = model.Start.AddMinutes(30);
        model.Color = "Yellow";


        //model.ID = Guid.NewGuid();
        //model.DataAtendimento = DateTime.UtcNow;

        await PopularDropDown();
        return View(model);


    }



    [HttpGet]
    [Route("Agendamento/Alterar/{id}")]
    public async Task<IActionResult> Edit(int id)
    {
        //if (id == Guid.Empty) return NotFound();

        var agendamentoDto = await _agendamentoService.GetById(id);
   

        if (agendamentoDto == null) return NotFound();

        await PopularDropDown();
        return View(agendamentoDto);
    }

  

    [HttpPost]
    public async Task<IActionResult> Edit(AppointmentDTO appontmentDto)
    {
        return await Gravar(appontmentDto);
    }


    private async Task<IActionResult> Gravar(AppointmentDTO appontmentDto)
    {
        var errors = ModelState.Values.SelectMany(v => v.Errors);

        if (ModelState.IsValid)
        {
            await _agendamentoService.Update(appontmentDto);
            return RedirectToAction(nameof(Index));
        }

        return View(appontmentDto);
    }





    //[Authorize(Roles = "Admin")]
    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        //if (id == Guid.Empty)
        //    return NotFound();

        var agendamentoDto = await _agendamentoService.GetById(id);

        if (agendamentoDto == null) return NotFound();

        return View(agendamentoDto);

    }

  


    [HttpPost(), ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _agendamentoService.Remove(id);
        return RedirectToAction("Index");
    }




 

    [HttpGet]
    public async Task<IActionResult> GetEventos()
    {
        List<AppointmentDTO> events = new List<AppointmentDTO>();

        var resultado = await  _agendamentoService.Getappointments();

        foreach (AppointmentDTO item in resultado)
        {
            var cor = item.Color;

            if (item.EventStatus == Dominio.Enums.AppointmentStatus.Aguardando)
            {
                cor = "#228B22";
                // Verde
            }
            if (item.EventStatus == Dominio.Enums.AppointmentStatus.Agendado) {
                cor = "#40E0D0"; 
                // Turquesa
            }

            if (item.EventStatus == Dominio.Enums.AppointmentStatus.Completo)
            {
                cor = "#0071c5";
                // Azul
            }

            if (item.EventStatus == Dominio.Enums.AppointmentStatus.Cancelado)
            {
                cor = "#8B0000";
                // Vermelho
            }

            if (item.EventStatus == Dominio.Enums.AppointmentStatus.Atrasado)
            {
                cor = "#FF4500";
                // Laranja
            }

            events.Add(new AppointmentDTO
            {
                Id = item.Id,
                Subject = item.Subject,
                Start = item.Start,
                End = item.End,
                Color = cor,
                ClienteId = item.ClienteId,
                Cliente = item.Cliente,
                NomeCliente = item.NomeCliente,
                Funcionario = item.Funcionario,
                FuncionarioId = item.FuncionarioId,
                NomeFuncionario = item.NomeFuncionario,
                Title = $"{item.Title} [{item.EventStatus}]",
                Description = item.Description,
                Location = item.Location,

                
                AllDay = item.AllDay,
                Other_details = item.Other_details

            });
        }


        return Json(events);
    }
}