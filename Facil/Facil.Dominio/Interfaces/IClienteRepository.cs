using Facil.Dominio.Entidades.DadosPessoa;

namespace Facil.Dominio.Interfaces;

public interface IClienteRepository
{
    Task<IEnumerable<Cliente>> GetClientesAsync();
    Task<Cliente> GetByIdAsync(Guid id);

    Task<Cliente> CreateAsync(Cliente cliente);
    Task<Cliente> UpdateAsync(Cliente cliente);
    Task<Cliente> RemoveAsync(Cliente cliente);
}
