using Facil.Aplicacao.CQRS.Clientes.Queries;
using Facil.Dominio.Entidades.DadosPessoa;
using Facil.Dominio.Interfaces;
using MediatR;

namespace Facil.Aplicacao.CQRS.Clientes.Handlers;

public class GetClientesByIdQueryHandler : IRequestHandler<GetClienteByIdQuery, Cliente>
{
    private readonly IClienteRepository _clienteRepository;

    public GetClientesByIdQueryHandler(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    public async Task<Cliente> Handle(GetClienteByIdQuery request,
         CancellationToken cancellationToken)
    {
        return await _clienteRepository.GetByIdAsync(request.Id);
    }
}