﻿using Facil.Dominio.Entidades.DadosPessoa;

namespace Facil.Dominio.Interfaces;

public interface IFuncionarioRepository
{
    Task<IEnumerable<Funcionario>> GetFuncionariosAsync();
    Task<Funcionario> GetByIdAsync(Guid id);

    Task<Funcionario> CreateAsync(Funcionario funcionario);
    Task<Funcionario> UpdateAsync(Funcionario funcionario);
    Task<Funcionario> RemoveAsync(Funcionario funcionario);

}
