using Facil.Dominio.Entidades.DadosPessoa;
using Facil.Dominio.Interfaces;
using Facil.Infra.Data.Contexto;
using Microsoft.EntityFrameworkCore;

namespace Facil.Infra.Data.Repositories;

public class ClienteRepositorio : IClienteRepository
{
    private ApplicationDbContext _clienteContext;

    public ClienteRepositorio(ApplicationDbContext clienteContext)
    {
        _clienteContext = clienteContext;
    }

    public async Task<Cliente> CreateAsync(Cliente cliente)
    {
        _clienteContext.Add(cliente);
        await _clienteContext.SaveChangesAsync();
        return cliente;
    }

    public async Task<Cliente> GetByIdAsync(Guid id)
    {
        return await _clienteContext.Clientes.SingleOrDefaultAsync(p => p.ID == id);
    }

    public async Task<IEnumerable<Cliente>> GetClientesAsync()
    {
        return await _clienteContext.Clientes.OrderBy(e => e.Nome).ToListAsync();
    }

    public async Task<Cliente> RemoveAsync(Cliente cliente)
    {
        _clienteContext.Remove(cliente);
        await _clienteContext.SaveChangesAsync();
        return cliente;
    }

    public async Task<Cliente> UpdateAsync(Cliente cliente)
    {
        _clienteContext.Update(cliente);
        await _clienteContext.SaveChangesAsync();
        return cliente;
    }
}
