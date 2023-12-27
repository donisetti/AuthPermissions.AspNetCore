using Facil.Aplicacao.CQRS.Funcionarios.Commands;
using Facil.Dominio.Entidades.DadosPessoa;
using Facil.Dominio.Interfaces;
using MediatR;

namespace Facil.Aplicacao.CQRS.Funcionarios.Handlers;

public class FuncionarioCreateCommandHandler : IRequestHandler<FuncionarioCreateCommand, Funcionario>
{
    private readonly IFuncionarioRepository _funcionarioRepository;

    public FuncionarioCreateCommandHandler(IFuncionarioRepository funcionarioRepository)
    {
        _funcionarioRepository = funcionarioRepository;
    }

    public async Task<Funcionario> Handle(FuncionarioCreateCommand request, CancellationToken cancellationToken)
    {
        var funcionario = new Funcionario(request.Codigo, request.Nome, request.Endereco, request.Fone, request.Rg, request.Cpf, request.Profissao, request.FoneTrabalho, request.Cep, request.Bairro, request.Municipio, request.Uf, request.Filiacao, request.EnderecoFiliacao, request.DataNascimento);

        if (funcionario == null)
        {
            throw new ApplicationException($"Erro na criação de entidade.");
        }
        else
        {
            //cliente.CategoryId = request.CategoryId;
            return await _funcionarioRepository.CreateAsync(funcionario);
        }
    }
}
