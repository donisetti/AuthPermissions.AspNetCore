using Facil.Aplicacao.CQRS.Agendamentos.Commands;
using Facil.Dominio.Entidades.Agenda;
using Facil.Dominio.Interfaces;
using MediatR;

namespace Facil.Aplicacao.CQRS.Agendamentos.Handlers;

public class AgendamentoRemoveCommandHandler : IRequestHandler<AgendamentoRemoveCommand, Appointment>
{
    private readonly IAgendamentoRepository _agendamentoRepository;

    public AgendamentoRemoveCommandHandler(IAgendamentoRepository gendamentoRepository)
    {
        _agendamentoRepository = gendamentoRepository;
    }

    async Task<Appointment> IRequestHandler<AgendamentoRemoveCommand, Appointment>.Handle(AgendamentoRemoveCommand request, CancellationToken cancellationToken)
    {
        var agendamento = await _agendamentoRepository.GetByIdAsync(request.Id);

        if (agendamento == null)
        {
            throw new ApplicationException($"agendamento não pode ser encontrado.");
        }
        else
        {
            var result = await _agendamentoRepository.RemoveAsync(agendamento);
            return result;
        }
    }
}
