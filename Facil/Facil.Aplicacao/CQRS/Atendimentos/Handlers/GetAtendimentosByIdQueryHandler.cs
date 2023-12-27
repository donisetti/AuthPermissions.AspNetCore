using Facil.Aplicacao.CQRS.Atendimentos.Queries;
using Facil.Dominio.Entidades;
using Facil.Dominio.Interfaces;
using MediatR;

namespace Facil.Aplicacao.CQRS.Atendimentos.Handlers;

public class GetAtendimentosByIdQueryHandler : IRequestHandler<GetAtendimentoByIdQuery, Atendimento>
{
    private readonly IAtendimentoRepository _atendimentoRepository;

    public GetAtendimentosByIdQueryHandler(IAtendimentoRepository atendimentoRepository)
    {
        _atendimentoRepository = atendimentoRepository;
    }

    public async Task<Atendimento> Handle(GetAtendimentoByIdQuery request, CancellationToken cancellationToken)
    {
        return await _atendimentoRepository.GetByIdAsync(request.Id);
    }
}
