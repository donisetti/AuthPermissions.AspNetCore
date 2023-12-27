using Facil.Aplicacao.CQRS.Funcionarios.Commands;
using Facil.Dominio.Entidades.DadosPessoa;
using Facil.Dominio.Interfaces;
using MediatR;

namespace Facil.Aplicacao.CQRS.Funcionarios.Handlers;

public class FuncionarioUpdateCommandHandler : IRequestHandler<FuncionarioUpdateCommand, Funcionario>
{
    private readonly IFuncionarioRepository _funcionarioRepository;

    public FuncionarioUpdateCommandHandler(IFuncionarioRepository funcionarioRepository)
    {
        _funcionarioRepository = funcionarioRepository;
    }

    public async Task<Funcionario> Handle(FuncionarioUpdateCommand request, CancellationToken cancellationToken)
    {
        var funcionario = await _funcionarioRepository.GetByIdAsync(request.Id);

        if (funcionario == null)
        {
            throw new ApplicationException($"Não foi possível localizar a entidade.");
        }
        else
        {
            funcionario.Update(request.Codigo, request.Nome, request.Endereco, request.Fone, request.Rg, request.Cpf, request.Profissao, request.FoneTrabalho, request.Cep, request.Bairro, request.Municipio, request.Uf, request.Filiacao, request.EnderecoFiliacao, request.DataNascimento);

            return await _funcionarioRepository.UpdateAsync(funcionario);

        }
    }
}
