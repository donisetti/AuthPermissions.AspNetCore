using Facil.Dominio.Entidades;
using MediatR;

namespace Facil.Aplicacao.CQRS.Atendimentos.Commands;

public abstract class AtendimentoCommand : IRequest<Atendimento>
{
    public Guid ID { get; set; }
    public DateTime DataAtendimento { get; set; }
    public string? Descricao { get; set; }
    public decimal? Valor { get; set; }
    public DateTime? DataPagamento { get; set; }
    public string? Observacao { get; set; }

    //chave estrangeira
    public Guid ClienteId { get; set; }
}
