using Facil.Aplicacao.CQRS.Atendimentos.Queries;
using Facil.Dominio.Entidades;
using Facil.Dominio.Interfaces;
using MediatR;

namespace Facil.Aplicacao.CQRS.Atendimentos.Handlers;

public class GetTodosAtendimentosQueryHandler : IRequestHandler<GetTodosAtendimentosQuery, IEnumerable<Atendimento>>
{
    private readonly IAtendimentoRepository _atendimentoRepository;

    public GetTodosAtendimentosQueryHandler(IAtendimentoRepository atendimentoRepository)
    {
        _atendimentoRepository = atendimentoRepository;
    }

    public async Task<IEnumerable<Atendimento>> Handle(GetTodosAtendimentosQuery request, CancellationToken cancellationToken)
    {
        return await _atendimentoRepository.GetTodosAtendimentosAsync(request.ClienteId, request.DataInicio, request.DataFim, request.FiltroData);
    }
}
