using Facil.Aplicacao.CQRS.Funcionarios.Queries;
using Facil.Dominio.Entidades.DadosPessoa;
using Facil.Dominio.Interfaces;
using MediatR;

namespace Facil.Aplicacao.CQRS.Funcionarios.Handlers;

public class GetFuncionarioByIdQueryHandler : IRequestHandler<GetFuncionarioByIdQuery, Funcionario>
{
    private readonly IFuncionarioRepository _funcionarioRepository;

    public GetFuncionarioByIdQueryHandler(IFuncionarioRepository funcionarioRepository)
    {
        _funcionarioRepository = funcionarioRepository;
    }

    public async Task<Funcionario> Handle(GetFuncionarioByIdQuery request, CancellationToken cancellationToken)
    {
        return await _funcionarioRepository.GetByIdAsync(request.Id);
    }
}
