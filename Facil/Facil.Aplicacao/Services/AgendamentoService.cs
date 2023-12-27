using AutoMapper;
using Facil.Aplicacao.DTOs;
using Facil.Aplicacao.Interfaces;
using Facil.Aplicacao.CQRS.Agendamentos.Commands;
using Facil.Aplicacao.CQRS.Agendamentos.Queries;
using MediatR;

namespace Facil.Aplicacao.Services;

public class AgendamentoService : IAgendamentoService
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public AgendamentoService(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    public async Task Add(AppointmentDTO appointmentDTO)
    {
        var agendamentoCreateCommand = _mapper.Map<AgendamentoCreateCommand>(appointmentDTO);
        await _mediator.Send(agendamentoCreateCommand);
    }

    public async Task<IEnumerable<AppointmentDTO>> Getappointments()
    {
        var query = new GetAgendamentoQuery();

        if (query == null)
            throw new Exception($"Entidade não pode ser carregada");

        var result = await _mediator.Send(query);
        return _mapper.Map<IEnumerable<AppointmentDTO>>(result);
    }

    

    public async Task<AppointmentDTO> GetById(int id)
    {
        var agendamentoByIdQuery = new GetAgendamentoByIdQuery(id);

        if (agendamentoByIdQuery == null)
            throw new Exception($"Entidade não pode ser carregada");

        var result = await _mediator.Send(agendamentoByIdQuery);

        return _mapper.Map<AppointmentDTO>(result);
    }

    

    public async Task Remove(int id)
    {
        var agendamentoRemoveCommand = new AgendamentoRemoveCommand(id);
        if (agendamentoRemoveCommand == null)
            throw new Exception($"Entidade não pode ser carregada");

        await _mediator.Send(agendamentoRemoveCommand);
    }

   

    public async Task Update(AppointmentDTO appointmentDTO)
    {

        var agendamentoUpdateCommand = _mapper.Map<AgendamentoUpdateCommand>(appointmentDTO);
        await _mediator.Send(agendamentoUpdateCommand);
    }
}
