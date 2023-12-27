using Facil.Aplicacao.CQRS.Atendimentos.Queries;
using Facil.Dominio.Entidades;
using Facil.Dominio.Interfaces;
using MediatR;

namespace Facil.Aplicacao.CQRS.Atendimentos.Handlers;

public class GetAtendimentosQueryHandler : IRequestHandler<GetAtendimentoQuery, IEnumerable<Atendimento>>
{
    private readonly IAtendimentoRepository _atendimentoRepository;

    public GetAtendimentosQueryHandler(IAtendimentoRepository atendimentoRepository)
    {
        _atendimentoRepository = atendimentoRepository;
    }

    public async Task<IEnumerable<Atendimento>> Handle(GetAtendimentoQuery request, CancellationToken cancellationToken)
    {
        return await _atendimentoRepository.GetAtendimentosAsync();
    }
}
