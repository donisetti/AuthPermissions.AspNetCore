using Facil.Dominio.Entidades.DadosPessoa;
using MediatR;

namespace Facil.Aplicacao.CQRS.Funcionarios.Queries;

public class GetFuncionarioByIdQuery : IRequest<Funcionario>
{
    public Guid Id { get; set; }

    public GetFuncionarioByIdQuery(Guid id)
    {
        Id = id;
    }

   
}
