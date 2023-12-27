using Facil.Aplicacao.CQRS.Clientes.Commands;
using Facil.Dominio.Entidades.DadosPessoa;
using Facil.Dominio.Interfaces;
using MediatR;

namespace Facil.Aplicacao.CQRS.Clientes.Handlers;


public class ClienteCreateCommandHandler : IRequestHandler<ClienteCreateCommand, Cliente>
{
    private readonly IClienteRepository _clienteRepository;
    public ClienteCreateCommandHandler(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    public async Task<Cliente> Handle(ClienteCreateCommand request, CancellationToken cancellationToken)
    {
        var cliente = new Cliente(request.Codigo, request.Nome, request.Endereco, request.Fone, request.Rg, request.Cpf, request.Profissao, request.FoneTrabalho, request.Cep, request.Bairro, request.Municipio,request.Uf, request.Filiacao, request.EnderecoFiliacao, request.DataNascimento);

        if (cliente == null)
        {
            throw new ApplicationException($"Error creating entity.");
        }
        else
        {
            //cliente.CategoryId = request.CategoryId;
            return await _clienteRepository.CreateAsync(cliente);
        }
    }
}

