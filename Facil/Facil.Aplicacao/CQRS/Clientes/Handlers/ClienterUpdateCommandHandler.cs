using Facil.Aplicacao.CQRS.Clientes.Commands;
using Facil.Dominio.Entidades.DadosPessoa;
using Facil.Dominio.Interfaces;
using MediatR;
using System.Runtime.ConstrainedExecution;

namespace Facil.Aplicacao.CQRS.Clientes.Handlers;


public class ClienterUpdateCommandHandler : IRequestHandler<ClienteUpdateCommand, Cliente>
{
    private readonly IClienteRepository _clienteRepository;
    public ClienterUpdateCommandHandler(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository ??
        throw new ArgumentNullException(nameof(clienteRepository));
    }

    public async Task<Cliente> Handle(ClienteUpdateCommand request,
        CancellationToken cancellationToken)
    {
        var cliente = await _clienteRepository.GetByIdAsync(request.Id);

        if (cliente == null)
        {
            throw new ApplicationException($"Entity could not be found.");
        }
        else
        {
            cliente.Update(request.Codigo, request.Nome, request.Endereco, request.Fone, request.Rg, request.Cpf, request.Profissao, request.FoneTrabalho, request.Cep, request.Bairro, request.Municipio, request.Uf, request.Filiacao, request.EnderecoFiliacao, request.DataNascimento);

            return await _clienteRepository.UpdateAsync(cliente);

        }
    }
}

