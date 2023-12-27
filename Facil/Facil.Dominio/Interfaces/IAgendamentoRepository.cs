using Facil.Dominio.Entidades.Agenda;

namespace Facil.Dominio.Interfaces;

public interface IAgendamentoRepository
{
    Task<IEnumerable<Appointment>> GetTodosAppointmentsAsync(Guid clienteId, DateTime dataInicio, DateTime dataFim, string filtroData);

    Task<IEnumerable<Appointment>> GetAgendamentosAsync();
    Task<Appointment> GetByIdAsync(int id);

    Task<Appointment> CreateAsync(Appointment appointment);
    Task<Appointment> UpdateAsync(Appointment appointment);
    Task<Appointment> RemoveAsync(Appointment appointment);

}
