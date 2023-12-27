namespace Facil.Dominio.Entidades;

public abstract class Entity
{
    public Entity()
    {
        DataCadastro = DateTime.UtcNow;
        DataAlteracao = DateTime.UtcNow;
    }
    public Guid ID { get; set; }   
    public bool Ativo { get; set; }
    public DateTime DataCadastro { get; set; }
    public DateTime DataAlteracao { get; set; }
    public string? UsuarioCadastro { get; set; }
    public string? UsuarioAlteracao { get; set; }

    public void Ativar()
    {
        Ativo = true;     
    }
    public void Inativar()
    { 
        Ativo = false;
    }   
}
