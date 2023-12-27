using Facil.Aplicacao.CQRS.Agendamentos.Queries;
using Facil.Dominio.Entidades.Agenda;
using Facil.Dominio.Interfaces;
using MediatR;

namespace Facil.Aplicacao.CQRS.Agendamentos.Handlers;

public class GetAgendamentosQueryHandler : IRequestHandler<GetAgendamentoQuery, IEnumerable<Appointment>>
{
    private readonly IAgendamentoRepository _agendamentoRepository;

    public GetAgendamentosQueryHandler(IAgendamentoRepository agendamentoRepository)
    {
        _agendamentoRepository = agendamentoRepository;
    }

    public async Task<IEnumerable<Appointment>> Handle(GetAgendamentoQuery request, CancellationToken cancellationToken)
    {
        return await _agendamentoRepository.GetAgendamentosAsync();
    }
}
