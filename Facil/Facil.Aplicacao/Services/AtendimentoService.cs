using AutoMapper;
using Facil.Aplicacao.DTOs;
using Facil.Aplicacao.Interfaces;
using Facil.Aplicacao.CQRS.Atendimentos.Commands;
using Facil.Aplicacao.CQRS.Atendimentos.Queries;
using MediatR;

namespace Facil.Aplicacao.Services;

public class AtendimentoService : IAppointmentService
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public AtendimentoService(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    public async Task Add(AtendimentoDTO AtendimentoDto)
    {
        var atendimentoCreateCommand = _mapper.Map<AtendimentoCreateCommand>(AtendimentoDto);
        await _mediator.Send(atendimentoCreateCommand);
    }

    public async Task<IEnumerable<AtendimentoDTO>> GetAtendimentos()
    {
        var query = new GetAtendimentoQuery();

        if (query == null)
            throw new Exception($"Entidade não pode ser carregada");

        var result = await _mediator.Send(query);
        return _mapper.Map<IEnumerable<AtendimentoDTO>>(result);        
    }

    public async Task<AtendimentoDTO> GetById(Guid id)
    {
        var atendimentoByIdQuery = new GetAtendimentoByIdQuery(id);

        if (atendimentoByIdQuery == null)
            throw new Exception($"Entidade não pode ser carregada");

        var result = await _mediator.Send(atendimentoByIdQuery);

        return _mapper.Map<AtendimentoDTO>(result);
    }

    public async Task<IEnumerable<AtendimentoDTO>> GetTodosAtendimentos(Guid clienteId, DateTime dataInicio, DateTime dataFim, string FiltroData)
    {
        var query = new GetTodosAtendimentosQuery(clienteId, dataInicio, dataFim, FiltroData);

        if (query == null)
            throw new Exception($"A entidade não pôde ser carregada.");

        var result = await _mediator.Send(query);

        return _mapper.Map<IEnumerable<AtendimentoDTO>>(result);

    }

    public async Task Remove(Guid id)
    {
        var atendimentoRemoveCommand = new AtendimentoRemoveCommand(id);
        if (atendimentoRemoveCommand == null)
            throw new Exception($"Entidade não pode ser carregada");

        await _mediator.Send(atendimentoRemoveCommand);
    }

    public async Task Update(AtendimentoDTO atendimentoDto)
    {
        var atendimentoUpdateCommand = _mapper.Map<AtendimentoUpdateCommand>(atendimentoDto);
        await _mediator.Send(atendimentoUpdateCommand);
    }
}
