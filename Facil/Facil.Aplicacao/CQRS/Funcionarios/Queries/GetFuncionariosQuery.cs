using Facil.Dominio.Entidades.DadosPessoa;
using MediatR;

namespace Facil.Aplicacao.CQRS.Funcionarios.Queries;

public class GetFuncionariosQuery : IRequest<IEnumerable<Funcionario>>
{

}
