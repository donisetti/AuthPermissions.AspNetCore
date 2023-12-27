using Facil.Aplicacao.CQRS.Funcionarios.Commands;
using Facil.Dominio.Entidades.DadosPessoa;
using Facil.Dominio.Interfaces;
using MediatR;

namespace Facil.Aplicacao.CQRS.Funcionarios.Handlers;

public class FuncionarioRemoveCommandHandler : IRequestHandler<FuncionarioRemoveCommand, Funcionario>
{
    private readonly IFuncionarioRepository _funcionarioRepository;

    public FuncionarioRemoveCommandHandler(IFuncionarioRepository funcionarioRepository)
    {
        _funcionarioRepository = funcionarioRepository;
    }

    public async Task<Funcionario> Handle(FuncionarioRemoveCommand request, CancellationToken cancellationToken)
    {
        var funcionario = await _funcionarioRepository.GetByIdAsync(request.Id);

        if (funcionario == null)
        {
            throw new ApplicationException($"Funcionário não pode ser encontrado.");
        }
        else
        {
            var result = await _funcionarioRepository.RemoveAsync(funcionario);
            return result;
        }
    }
}
