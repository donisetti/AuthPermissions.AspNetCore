using Facil.Dominio.Entidades.Agenda;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Facil.Infra.Data.EntitiesConfiguration;

public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
{
    public void Configure(EntityTypeBuilder<Appointment> builder)
    {
        builder.Property(x => x.Other_details).IsRequired().HasMaxLength(350);
        builder.Property(x => x.Color).IsRequired().HasMaxLength(150); 
    }
}
