using Facil.Dominio.Entidades.DadosPessoa;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Facil.Infra.Data.EntitiesConfiguration;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Clientes");

        builder.HasKey(t => t.ID);
        //builder.HasIndex(t => t.Codigo).IsUnique();
        builder.Property(p => p.Nome).HasMaxLength(60).IsRequired();
        builder.Property(p => p.Municipio).HasMaxLength(100);
        builder.Property(p => p.Uf).HasMaxLength(2);
        builder.Property(p => p.Endereco).HasMaxLength(100);
        builder.Property(p => p.Bairro).HasMaxLength(100);
        builder.Property(p => p.Cep).HasMaxLength(60);
        builder.Property(p => p.EnderecoFiliacao).HasMaxLength(100);
        builder.Property(p => p.Fone).HasMaxLength(50);
        builder.Property(p => p.FoneTrabalho).HasMaxLength(50);
        builder.Property(p => p.Rg).HasMaxLength(20);
        builder.Property(p => p.Cpf).HasMaxLength(15);
        builder.Property(p => p.Profissao).HasMaxLength(40);
        builder.Property(p => p.Filiacao).HasMaxLength(60);
        //builder.Property(p => p.UsuarioCadastro).HasMaxLength(256);
        //builder.Property(p => p.UsuarioAlteracao).HasMaxLength(256);

        //builder.Property(p => p.IdEstrangeiro).HasMaxLength(20);
        //builder.Property(p => p.IE).HasMaxLength(14);
        //builder.Property(p => p.IndIEDest).HasMaxLength(1);
        //builder.Property(p => p.IM).HasMaxLength(15);
        //builder.Property(p => p.ISUF).HasMaxLength(9);
    }
}
