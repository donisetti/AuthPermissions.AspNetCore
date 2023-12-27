namespace Facil.Aplicacao.CQRS.Atendimentos.Commands;

public class AtendimentoUpdateCommand : AtendimentoCommand
{
    public Guid Id { get; set; }
}
