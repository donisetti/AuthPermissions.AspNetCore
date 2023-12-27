using Facil.Dominio.Entidades.DadosPessoa;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Facil.Aplicacao.DTOs;

public class AtendimentoDTO
{
    public AtendimentoDTO()
    {
        ID = Guid.NewGuid();
        DataAtendimento = DateTime.UtcNow;
    }
    public Guid ID { get; set; }
       

    [Required(ErrorMessage = "A data do atendimento é obrigatória")]
    [DisplayName("Data do Atendimento")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    [DataType(DataType.Date)]
    public DateTime DataAtendimento { get; set; } 

    [Required(ErrorMessage = "A descrição é obrigatória")]
    [DisplayName("Descrição")]
    [MinLength(3, ErrorMessage = "Minimo 3 caracteres.")]
    [MaxLength(200, ErrorMessage = "Maximo 200 caracteres.")]
    public string? Descricao { get; set; }
    
    public decimal? Valor { get; set; }

    [DisplayName("Data do Pagamento")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    [DataType(DataType.Date)]
    public DateTime? DataPagamento { get; set; }

    [DisplayName("Observação")]
    public string? Observacao { get; set; }


    [JsonIgnore]
    [DisplayName("Cliente")]
    public Cliente? Cliente { get; set; }

    [DisplayName("Clientes")]
    [Required(ErrorMessage = "O Cliente é obrigatório")]
    public Guid ClienteId { get; set; } = Guid.Empty;

}
