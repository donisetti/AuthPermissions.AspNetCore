using Facil.Aplicacao.CQRS.Clientes.Queries;
using Facil.Dominio.Entidades.DadosPessoa;
using Facil.Dominio.Interfaces;
using MediatR;

namespace Facil.Aplicacao.CQRS.Clientes.Handlers;

public class GetClientesQueryHandler : IRequestHandler<GetClientesQuery, IEnumerable<Cliente>>
{
    private readonly IClienteRepository _clienteRepository;

    public GetClientesQueryHandler(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    public async Task<IEnumerable<Cliente>> Handle(GetClientesQuery request,
        CancellationToken cancellationToken)
    {
        return await _clienteRepository.GetClientesAsync();
    }
}