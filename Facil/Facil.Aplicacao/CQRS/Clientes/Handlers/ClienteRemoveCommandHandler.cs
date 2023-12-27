using Facil.Aplicacao.CQRS.Clientes.Commands;
using Facil.Dominio.Entidades.DadosPessoa;
using Facil.Dominio.Interfaces;
using MediatR;

namespace Facil.Aplicacao.CQRS.Clientes.Handlers;


public class ClienteRemoveCommandHandler : IRequestHandler<ClienteRemoveCommand, Cliente>
{
    private readonly IClienteRepository _clienteRepository;

    public ClienteRemoveCommandHandler(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository ?? throw new
            ArgumentNullException(nameof(clienteRepository));
    }

    public async Task<Cliente> Handle(ClienteRemoveCommand request,
        CancellationToken cancellationToken)
    {
        var cliente = await _clienteRepository.GetByIdAsync(request.Id);

        if (cliente == null)
        {
            throw new ApplicationException($"Cliente não pode ser encontrado.");
        }
        else
        {
            var result = await _clienteRepository.RemoveAsync(cliente);
            return result;
        }
    }
}

