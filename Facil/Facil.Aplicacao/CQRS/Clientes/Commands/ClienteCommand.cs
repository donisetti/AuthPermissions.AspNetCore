using Facil.Dominio.Entidades.DadosPessoa;
using MediatR;

namespace Facil.Aplicacao.CQRS.Clientes.Commands;

public abstract class ClienteCommand : IRequest<Cliente>
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public string? Endereco { get; set; }
    public string? Fone { get; set; }
    public string? Rg { get; set; }
    public string? Cpf { get; set; }
    public string? Profissao { get; set; }
    public string? FoneTrabalho { get; set; }
    public string? Cep { get; set; }
    public string? Bairro { get; set; }
    public string? Municipio { get; set; }
    public string? Uf { get; set; }
    public string? Filiacao { get; set; }
    public string? EnderecoFiliacao { get; set; }
    public DateTime? DataNascimento { get; set; }

}
