using Facil.Dominio.Entidades.DadosPessoa;
using Facil.Dominio.Validation;
using System.Drawing;

namespace Facil.Dominio.Entidades;

public class Atendimento : Entity
{
    public DateTime DataAtendimento { get; set; }
    public string? Descricao { get; set; }
    public decimal? Valor { get; set; }
    public DateTime? DataPagamento { get; set; }
    public string? Observacao { get; set; }

    public Atendimento(Guid id, DateTime dataAtendimento, string? descricao, decimal? valor, DateTime? dataPagamento, string? observacao, Guid clienteId)
    {
        ID = id;

        ValidateDomain(dataAtendimento, descricao, valor, dataPagamento, observacao, clienteId);        
    }
    public Atendimento(DateTime dataAtendimento, string? descricao, decimal? valor, DateTime? dataPagamento, string? observacao, Guid clienteId)
    {
        ValidateDomain(dataAtendimento, descricao, valor, dataPagamento, observacao, clienteId);
    }

    public void Update(DateTime dataAtendimento, string? descricao, decimal? valor, DateTime? dataPagamento, string? observacao, Guid clienteId)
    {
        ValidateDomain(dataAtendimento, descricao, valor, dataPagamento, observacao, clienteId); 
    }

    private void ValidateDomain(DateTime dataAtendimento, string? descricao, decimal? valor, DateTime? dataPagamento, string? observacao, Guid clienteId)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(descricao), "A Descrição é obrigatória");
        DomainExceptionValidation.When(valor < 0, "O valor está inválido");
        DomainExceptionValidation.When(dataAtendimento == DateTime.MinValue, "O Data do Atendimento é obrigatória");

        //DomainExceptionValidation.When(DataPagamento == DateTime.MinValue, "O Data do Atendimento é obrigatória");

        DataAtendimento = dataAtendimento;
        Descricao = descricao;
        Valor = valor;
        DataPagamento = dataPagamento;
        Observacao = observacao;
        ClienteId = clienteId;
    }


    public Guid ClienteId { get; set; } = Guid.Empty;
    public Cliente Cliente { get; set; } 
}
