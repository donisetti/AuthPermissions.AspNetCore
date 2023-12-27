using Facil.Dominio.Entidades.DadosPessoa;
using MediatR;

namespace Facil.Aplicacao.CQRS.Clientes.Queries;

public class GetClienteByIdQuery : IRequest<Cliente>
{
    public Guid Id { get; set; }
    public GetClienteByIdQuery(Guid id)
    {
        Id = id;
    }
}