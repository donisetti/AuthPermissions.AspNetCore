using AutoMapper;
using Facil.Aplicacao.DTOs;
using Facil.Aplicacao.Interfaces;
using Facil.Aplicacao.CQRS.Clientes.Commands;
using Facil.Aplicacao.CQRS.Clientes.Queries;
using MediatR;

namespace Facil.Aplicacao.Services;


public class ClienteService : IClienteService
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;
    public ClienteService(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    public async Task<IEnumerable<ClienteDTO>> GetClientes()
    {
        var clientesQuery = new GetClientesQuery();

        if (clientesQuery == null)
            throw new Exception($"Entidade não pode ser carregada");

        var result = await _mediator.Send(clientesQuery);

        return _mapper.Map<IEnumerable<ClienteDTO>>(result);
    }

    public async Task<ClienteDTO> GetById(Guid id)
    {
        var clienteByIdQuery = new GetClienteByIdQuery(id);

        if (clienteByIdQuery == null)
            throw new Exception($"Entidade não pode ser carregada");

        var result = await _mediator.Send(clienteByIdQuery);

        return _mapper.Map<ClienteDTO>(result);
    }



    public async Task Add(ClienteDTO clienteDto)
    {
        var clienteCreateCommand = _mapper.Map<ClienteCreateCommand>(clienteDto);
        await _mediator.Send(clienteCreateCommand);
    }

    public async Task Update(ClienteDTO clienteDto)
    {
        var clienteUpdateCommand = _mapper.Map<ClienteUpdateCommand>(clienteDto);
        await _mediator.Send(clienteUpdateCommand);
    }

    public async Task Remove(Guid id)
    {
        var clienteRemoveCommand = new ClienteRemoveCommand(id);
        if (clienteRemoveCommand == null)
            throw new Exception($"Entidade não pode ser carregada");

        await _mediator.Send(clienteRemoveCommand);
    }


}

