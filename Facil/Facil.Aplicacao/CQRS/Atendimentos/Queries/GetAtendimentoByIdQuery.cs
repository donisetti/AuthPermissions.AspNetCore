using Facil.Dominio.Entidades;
using MediatR;

namespace Facil.Aplicacao.CQRS.Atendimentos.Queries;

public class GetAtendimentoByIdQuery : IRequest<Atendimento>
{
    public Guid Id { get; set; }
    public GetAtendimentoByIdQuery(Guid id)
    {
        Id = id;
    }
}

