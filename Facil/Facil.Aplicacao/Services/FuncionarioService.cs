using AutoMapper;
using Facil.Aplicacao.DTOs;
using Facil.Aplicacao.Interfaces;
using Facil.Aplicacao.CQRS.Funcionarios.Commands;
using Facil.Aplicacao.CQRS.Funcionarios.Queries;
using MediatR;

namespace Facil.Aplicacao.Services
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public FuncionarioService(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task Add(FuncionarioDTO funcionarioDTO)
        {
            var funcionarioCreateCommand = _mapper.Map<FuncionarioCreateCommand>(funcionarioDTO);
            await _mediator.Send(funcionarioCreateCommand);
        }

        public async Task<FuncionarioDTO> GetById(Guid id)
        {
            var funcionarioByIdQuery = new GetFuncionarioByIdQuery(id);

            if (funcionarioByIdQuery == null)
                throw new Exception($"Entidade não pode ser carregada");

            var result = await _mediator.Send(funcionarioByIdQuery);

            return _mapper.Map<FuncionarioDTO>(result);
        }

        public async Task<IEnumerable<FuncionarioDTO>> GetFuncionarios()
        {
            var query = new GetFuncionariosQuery();

            if (query == null)
                throw new Exception($"Entidade não pode ser carregada");

            var result = await _mediator.Send(query);

            return _mapper.Map<IEnumerable<FuncionarioDTO>>(result);
        }

        public async Task Remove(Guid id)
        {
            var funcionarioRemoveCommand = new FuncionarioRemoveCommand(id);

            if (funcionarioRemoveCommand == null)
                throw new Exception($"Entidade não pode ser carregada");

            await _mediator.Send(funcionarioRemoveCommand);
        }

        public async Task Update(FuncionarioDTO funcionarioDTO)
        {
            var funcionarioUpdateCommand = _mapper.Map<FuncionarioUpdateCommand>(funcionarioDTO);
            await _mediator.Send(funcionarioUpdateCommand);
        }
    }
}
