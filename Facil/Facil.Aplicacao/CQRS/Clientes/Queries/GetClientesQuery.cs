using Facil.Dominio.Entidades.DadosPessoa;
using MediatR;

namespace Facil.Aplicacao.CQRS.Clientes.Queries;

public class GetClientesQuery : IRequest<IEnumerable<Cliente>>
{

}
