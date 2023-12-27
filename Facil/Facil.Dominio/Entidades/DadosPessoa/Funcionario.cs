using Facil.Dominio.Validation;

namespace Facil.Dominio.Entidades.DadosPessoa;

public class Funcionario : Pessoa
{
    public Funcionario(string nome) : base(nome) /// todos os campos
    {
        ValidateDomain(0, nome, "", "", "", "", "", "", "", "", "", "", "", "", null);
    }


    public Funcionario(int codigo, string nome, string? endereco, string? fone, string? rg, string? cpf, string? profissao, string? foneTrabalho, string? cep, string? bairro, string? municipio, string? uf, string? filiacao, string? enderecoFiliacao, DateTime? dataNascimento)
    : base(codigo, nome, endereco, fone, rg, cpf, profissao, foneTrabalho, cep, bairro, municipio, uf, filiacao, enderecoFiliacao, dataNascimento) /// todos os campos
    {
        ValidateDomain(codigo, nome, endereco, fone, rg, cpf, profissao, foneTrabalho, cep, bairro, municipio, uf, filiacao, enderecoFiliacao, dataNascimento);
    }

    public void Update(int codigo, string nome, string? endereco, string? fone, string? rg, string? cpf, string? profissao, string? foneTrabalho, string? cep, string bairro, string? municipio, string? uf, string? filiacao, string? enderecoFiliacao, DateTime? dataNascimento)
    {
        ValidateDomain(codigo, nome, endereco, fone, rg, cpf, profissao, foneTrabalho, cep, bairro, municipio, uf, filiacao, enderecoFiliacao, dataNascimento);
    }



    private void ValidateDomain(int codigo, string nome, string? endereco, string? fone, string? rg, string? cpf, string? profissao, string? foneTrabalho, string? cep, string bairro, string? municipio, string? uf, string? filiacao, string? enderecoFiliacao, DateTime? dataNascimento)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(nome),
            "Nome inválido. O nome é obrigatório");

        DomainExceptionValidation.When(nome.Length < 3,
            "Nome inválido, muito curto, mínimo 3 caracteres");

        Codigo = codigo;
        Nome = nome;
        Endereco = endereco;
        Fone = fone;
        Rg = rg;
        Cpf = cpf;
        Profissao = profissao;
        FoneTrabalho = foneTrabalho;
        Cep = cep;
        Bairro = bairro;
        Municipio = municipio;
        Filiacao = filiacao;
        Uf = uf;
        EnderecoFiliacao = enderecoFiliacao;
    }

}
