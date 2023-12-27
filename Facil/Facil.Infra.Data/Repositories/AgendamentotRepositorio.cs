using Facil.Dominio.Entidades.Agenda;
using Facil.Dominio.Interfaces;
using Facil.Infra.Data.Contexto;
using Microsoft.EntityFrameworkCore;

namespace Facil.Infra.Data.Repositories;

public class AgendamentoRepositorio : IAgendamentoRepository
{
    private ApplicationDbContext _agendamentoContext;

    public AgendamentoRepositorio(ApplicationDbContext agendamentoContext)
    {
        _agendamentoContext = agendamentoContext;
    }

    public async Task<Appointment> CreateAsync(Appointment appointment)
    {
        try
        {
            _agendamentoContext.Add(appointment);
            await _agendamentoContext.SaveChangesAsync();
        }
        catch (Exception erro)
        {
            var msg = erro.Message;
           
        }
       

        return appointment;
    }

    public async Task<IEnumerable<Appointment>> GetAgendamentosAsync()
    {
        return await _agendamentoContext.Appointments.Include(c => c.Cliente).Include(c => c.Funcionario).OrderBy(e => e.Start).ToListAsync();
    }

    public async Task<Appointment> GetByIdAsync(int id)
    {
        return await _agendamentoContext.Appointments.Include(c => c.Cliente).Include(c => c.Funcionario).SingleOrDefaultAsync(p => p.Id == id);
    }

    public async Task<IEnumerable<Appointment>> GetTodosAppointmentsAsync(Guid clienteId, DateTime dataInicio, DateTime dataFim, string filtroData)
    {
        var lista = _agendamentoContext.Appointments.Include(c => c.Cliente).Include(c => c.Funcionario)
        .Where(v => v.Start >= dataInicio && v.End <= dataFim)
        .AsNoTracking().AsQueryable();

        if (clienteId != Guid.Empty)
        {
            //lista = lista.Where(v => v.ClienteId == clienteId);
        }

        return await lista.ToListAsync();
    }

    public async Task<Appointment> RemoveAsync(Appointment appointment)
    {
        _agendamentoContext.Remove(appointment);
        await _agendamentoContext.SaveChangesAsync();
        return appointment;
    }

    public async Task<Appointment> UpdateAsync(Appointment appointment)
    {
        _agendamentoContext.Update(appointment);
        await _agendamentoContext.SaveChangesAsync();
        return appointment;
    }
}
