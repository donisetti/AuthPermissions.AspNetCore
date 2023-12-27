using Facil.Aplicacao.DTOs;

namespace Facil.Aplicacao.Interfaces;

public interface IAppointmentService
{
    Task<IEnumerable<AtendimentoDTO>> GetAtendimentos();
    Task<IEnumerable<AtendimentoDTO>> GetTodosAtendimentos(Guid clienteId, DateTime dataInicio, DateTime dataFim, string FiltroData);
    Task<AtendimentoDTO> GetById(Guid id);
    Task Add(AtendimentoDTO AtendimentoDto);
    Task Update(AtendimentoDTO AtendimentoDto);
    Task Remove(Guid id);
}
