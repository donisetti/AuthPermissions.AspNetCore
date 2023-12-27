namespace Facil.Aplicacao.CQRS.Funcionarios.Commands;

public class FuncionarioUpdateCommand : FuncionarioCommand
{
    public Guid Id { get; set; }
}
