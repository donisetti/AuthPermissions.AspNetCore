using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Facil.Aplicacao.DTOs;

public class FuncionarioDTO
{
    public Guid ID { get; set; }

    [Required(ErrorMessage = "O Nome é Obrigatório")]
    public string Nome { get; set; }

    
    [DisplayName("Código")]
    [Range(0, int.MaxValue, ErrorMessage = "Informe um código")]
    public int Codigo { get; set; } = 0;

    [DisplayName("Data de Nascimento")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "A data está inválida")]
    public DateTime? DataNascimento { get; set; } = DateTime.MinValue;

    [DisplayName("Endereço")]
    public string? Endereco { get; set; }
    public string? Fone { get; set; }

    [DisplayName("RG")]
    public string? Rg { get; set; }

    [DisplayName("CPF")]
    public string? Cpf { get; set; }

    [DisplayName("Profissão")]
    public string? Profissao { get; set; }
    [DisplayName("Fone do Trabalho")]
    public string? FoneTrabalho { get; set; }
    public string? Cep { get; set; }
    public string? Bairro { get; set; }
    [DisplayName("Município")]
    public string? Municipio { get; set; }

    public string? Uf { get; set; }
    [DisplayName("Filiação")]
    public string? Filiacao { get; set; }

    [DisplayName("Endereço Filiação")]
    public string? EnderecoFiliacao { get; set; }

    public string? EnderecoCompleto
    {
        get { return $"{Endereco} {Bairro} {Municipio} {Uf}"; }
    }

    
}
