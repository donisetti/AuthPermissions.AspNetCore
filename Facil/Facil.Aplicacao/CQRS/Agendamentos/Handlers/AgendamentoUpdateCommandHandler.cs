using Facil.Aplicacao.CQRS.Agendamentos.Commands;
using Facil.Dominio.Entidades.Agenda;
using Facil.Dominio.Interfaces;
using MediatR;

namespace Facil.Aplicacao.CQRS.Agendamentos.Handlers;

public class AgendamentoUpdateCommandHandler : IRequestHandler<AgendamentoUpdateCommand, Appointment>
{
    private readonly IAgendamentoRepository _agendamentoRepository;

    public AgendamentoUpdateCommandHandler(IAgendamentoRepository agendamentoRepository)
    {
        _agendamentoRepository = agendamentoRepository;
    }

    public async Task<Appointment> Handle(AgendamentoUpdateCommand request, CancellationToken cancellationToken)
    {
        var agendamento = await _agendamentoRepository.GetByIdAsync(request.Id);

        if (agendamento == null)
        {
            throw new ApplicationException($"Entity could not be found.");
        }
        else
        {
            agendamento.Update(request.Id, request.ClienteId, request.FuncionarioId, request.EventStatus, request.Start, request.End, request.Color, request.AllDay, request.Other_details, request.Subject, request.Description, request.Location, request.Title);

            return await _agendamentoRepository.UpdateAsync(agendamento);

        }
    }
}
