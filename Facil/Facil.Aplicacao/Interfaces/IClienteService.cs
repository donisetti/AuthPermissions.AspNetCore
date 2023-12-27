using Facil.Aplicacao.DTOs;

namespace Facil.Aplicacao.Interfaces
{
    public interface IClienteService
    {
        Task<IEnumerable<ClienteDTO>> GetClientes();

        Task<ClienteDTO> GetById(Guid id);
       
        Task Add(ClienteDTO clienteDto);
        Task Update(ClienteDTO clienteDto);
        Task Remove(Guid id);
    }
}
