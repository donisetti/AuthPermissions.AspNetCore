using Facil.Dominio.Entidades.DadosPessoa;
using MediatR;

namespace Facil.Aplicacao.CQRS.Funcionarios.Commands;

public class FuncionarioRemoveCommand : IRequest<Funcionario>
{
    public Guid Id { get; set; }

    public FuncionarioRemoveCommand(Guid id)
    {
        Id = id;
    }

   
}
