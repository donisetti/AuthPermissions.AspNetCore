namespace Facil.Aplicacao.CQRS.Clientes.Commands;

public class ClienteUpdateCommand : ClienteCommand
{
    public Guid Id { get; set; }
}
