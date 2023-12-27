using Facil.Dominio.Entidades.DadosPessoa;
using MediatR;

namespace Facil.Aplicacao.CQRS.Clientes.Commands;

public class ClienteRemoveCommand : IRequest<Cliente>
{
    public Guid Id { get; set; }
    public ClienteRemoveCommand(Guid id)
    {
        Id = id;
    }
}