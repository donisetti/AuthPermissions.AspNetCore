using Facil.Dominio.Entidades;
using Facil.Dominio.Entidades.Agenda;
using Facil.Dominio.Entidades.DadosPessoa;
using Facil.Infra.Data.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Facil.Infra.Data.Contexto;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{

   
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Atendimento> Atendimentos { get; set; }

    public DbSet<Appointment> Appointments { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
