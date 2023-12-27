using Facil.Dominio.Entidades.DadosPessoa;
using Facil.Dominio.Interfaces;
using Facil.Infra.Data.Contexto;
using Microsoft.EntityFrameworkCore;

namespace Facil.Infra.Data.Repositories;

public class FuncionarioRepositorio : IFuncionarioRepository
{
    private ApplicationDbContext _funcionarioContext;

    public FuncionarioRepositorio(ApplicationDbContext funcionarioContext)
    {
        _funcionarioContext = funcionarioContext;
    }

    public async Task<Funcionario> CreateAsync(Funcionario funcionario)
    {
        try
        {
            _funcionarioContext.Add(funcionario);
            await _funcionarioContext.SaveChangesAsync();
        }
        catch (Exception erro)
        {
            var msg = erro.ToString();
           
        }
       
        return funcionario;
    }

    public async Task<Funcionario> GetByIdAsync(Guid id)
    {
        return await _funcionarioContext.Funcionarios.SingleOrDefaultAsync(p => p.ID == id);
    }

    public async Task<IEnumerable<Funcionario>> GetFuncionariosAsync()
    {
        return await _funcionarioContext.Funcionarios.OrderBy(e => e.Nome).ToListAsync();
    }

    public async Task<Funcionario> RemoveAsync(Funcionario funcionario)
    {
        _funcionarioContext.Remove(funcionario);
        await _funcionarioContext.SaveChangesAsync();
        return funcionario;
    }

    public async Task<Funcionario> UpdateAsync(Funcionario funcionario)
    {
        _funcionarioContext.Update(funcionario);
        await _funcionarioContext.SaveChangesAsync();
        return funcionario;
    }
}
