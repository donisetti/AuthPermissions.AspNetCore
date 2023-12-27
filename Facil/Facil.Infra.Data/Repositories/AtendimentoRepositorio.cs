using Facil.Dominio.Entidades;
using Facil.Dominio.Entidades.DadosPessoa;
using Facil.Dominio.Interfaces;
using Facil.Infra.Data.Contexto;
using Microsoft.EntityFrameworkCore;

namespace Facil.Infra.Data.Repositories;

public class AtendimentoRepositorio : IAtendimentoRepository
{
    private ApplicationDbContext _atendimentoContext;

    public AtendimentoRepositorio(ApplicationDbContext context)
    {
        _atendimentoContext = context;
    }

    public async Task<Atendimento> CreateAsync(Atendimento atendimento)
    {
        _atendimentoContext.Add(atendimento);
        await _atendimentoContext.SaveChangesAsync();
        return atendimento;
    }

    public async Task<IEnumerable<Atendimento>> GetAtendimentosAsync()
    {
        return await _atendimentoContext.Atendimentos.Include(c => c.Cliente).OrderBy(e => e.DataAtendimento).ToListAsync();
    }

    public async Task<Atendimento> GetByIdAsync(Guid id)
    {
        return await _atendimentoContext.Atendimentos.SingleOrDefaultAsync(p => p.ID == id);
    }

    public async Task<IEnumerable<Atendimento>> GetTodosAtendimentosAsync(Guid clienteId, DateTime dataInicio, DateTime dataFim, string filtroData)
    {
        var lista = _atendimentoContext.Atendimentos.Include(c => c.Cliente)
        .Where(v => v.DataAtendimento >= dataInicio && v.DataAtendimento <= dataFim)
        .AsNoTracking().AsQueryable();

        if (clienteId != Guid.Empty)
        {
            lista = lista.Where(v => v.ClienteId == clienteId);
        }
        
        return await lista.ToListAsync();
    }

    public async Task<Atendimento> RemoveAsync(Atendimento atendimento)
    {
        _atendimentoContext.Remove(atendimento);
        await _atendimentoContext.SaveChangesAsync();
        return atendimento;
    }

    public async Task<Atendimento> UpdateAsync(Atendimento atendimento)
    {
        _atendimentoContext.Update(atendimento);
        await _atendimentoContext.SaveChangesAsync();
        return atendimento;
    }
}
