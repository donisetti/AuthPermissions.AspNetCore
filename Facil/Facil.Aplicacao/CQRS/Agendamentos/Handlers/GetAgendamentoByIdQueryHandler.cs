using Facil.Aplicacao.CQRS.Agendamentos.Queries;
using Facil.Dominio.Entidades.Agenda;
using Facil.Dominio.Interfaces;
using MediatR;

namespace Facil.Aplicacao.CQRS.Agendamentos.Handlers;

public class GetAgendamentoByIdQueryHandler : IRequestHandler<GetAgendamentoByIdQuery, Appointment>
{
    private readonly IAgendamentoRepository _agendamentoRepository;

    public GetAgendamentoByIdQueryHandler(IAgendamentoRepository agendamentoRepository)
    {
        _agendamentoRepository = agendamentoRepository;
    }

    public async Task<Appointment> Handle(GetAgendamentoByIdQuery request, CancellationToken cancellationToken)
    {
        return await _agendamentoRepository.GetByIdAsync(request.Id);
    }
}
