using Facil.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Facil.Infra.Data.EntitiesConfiguration;

public class AtendimentoConfiguration : IEntityTypeConfiguration<Atendimento>
{
    public void Configure(EntityTypeBuilder<Atendimento> builder)
    {
        builder.ToTable("Atendimentos");

        builder.HasKey(t => t.ID);

        builder.Property(p => p.DataAtendimento).IsRequired();
        builder.Property(p => p.Descricao).HasMaxLength(200).IsRequired();
        builder.Property(p => p.Observacao).HasMaxLength(200);
        builder.Property(p => p.Valor).HasPrecision(10, 2);


        builder.HasOne(e => e.Cliente).WithMany(e => e.Atendimentos)
            .HasForeignKey(e => e.ClienteId).OnDelete(DeleteBehavior.NoAction);
    }
}
