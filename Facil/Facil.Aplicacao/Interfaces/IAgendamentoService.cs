using Facil.Aplicacao.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace Facil.Aplicacao.Interfaces;

public interface IAgendamentoService
{
    Task<IEnumerable<AppointmentDTO>> Getappointments();
    //Task<IEnumerable<JsonResult>> GetappointmentsJson();


    Task<AppointmentDTO> GetById(int id);
    //Task<AppointmentDTO> GetByCliente(Guid clienteId);
    //Task<AppointmentDTO> GetByProfissional(Guid profissionalId);
    //Task<AppointmentDTO> GetByClientePeriodo(Guid clienteId, DateTime dataInicio, DateTime dataFim);
    //Task<AppointmentDTO> GetByProfissionalPeriodo(Guid profissionalId, DateTime dataInicio, DateTime dataFim, string FiltroData);


    Task Add(AppointmentDTO appointmentDTO);
    Task Update(AppointmentDTO appointmentDTO);
    Task Remove(int id);
  
}
