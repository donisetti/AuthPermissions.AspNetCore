namespace Facil.Aplicacao.CQRS.Agendamentos.Commands;

public class AgendamentoUpdateCommand : AgendamentoCommand
{
    public int Id { get; set; }
}
