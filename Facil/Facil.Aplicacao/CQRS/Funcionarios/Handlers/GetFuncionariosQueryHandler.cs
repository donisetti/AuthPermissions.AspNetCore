using Facil.Aplicacao.CQRS.Clientes.Queries;
using Facil.Aplicacao.CQRS.Funcionarios.Queries;
using Facil.Dominio.Entidades.DadosPessoa;
using Facil.Dominio.Interfaces;
using MediatR;

namespace Facil.Aplicacao.CQRS.Funcionarios.Handlers;

public class GetFuncionariosQueryHandler : IRequestHandler<GetFuncionariosQuery, IEnumerable<Funcionario>>
{
    private readonly IFuncionarioRepository _funcionarioRepository;

    public GetFuncionariosQueryHandler(IFuncionarioRepository funcionarioRepository)
    {
        _funcionarioRepository = funcionarioRepository;
    }

  

    public async Task<IEnumerable<Funcionario>> Handle(GetFuncionariosQuery request, CancellationToken cancellationToken)
    {
        return await _funcionarioRepository.GetFuncionariosAsync();
    }
}

