using Facil.Aplicacao.DTOs;

namespace Facil.Aplicacao.Interfaces;

public interface IFuncionarioService
{
    Task<IEnumerable<FuncionarioDTO>> GetFuncionarios();

    Task<FuncionarioDTO> GetById(Guid id);

    Task Add(FuncionarioDTO FuncionarioDTO);
    Task Update(FuncionarioDTO FuncionarioDTO);
    Task Remove(Guid id);
}
