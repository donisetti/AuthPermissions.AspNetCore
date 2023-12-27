using Facil.Dominio.Entidades;
using Facil.Dominio.Entidades.DadosPessoa;
using System.ComponentModel;

namespace Facil.Dominio.Interfaces;

public interface IAtendimentoRepository
{ 
    Task<IEnumerable<Atendimento>> GetTodosAtendimentosAsync(Guid clienteId, DateTime dataInicio, DateTime dataFim, string filtroData);
    Task<IEnumerable<Atendimento>> GetAtendimentosAsync();
    Task<Atendimento> GetByIdAsync(Guid id);

    Task<Atendimento> CreateAsync(Atendimento atendimento);
    Task<Atendimento> UpdateAsync(Atendimento atendimento);
    Task<Atendimento> RemoveAsync(Atendimento atendimento);

    
}
