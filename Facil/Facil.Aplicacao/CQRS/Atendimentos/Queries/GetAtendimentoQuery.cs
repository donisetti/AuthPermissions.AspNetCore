using Facil.Dominio.Entidades;
using MediatR;

namespace Facil.Aplicacao.CQRS.Atendimentos.Queries;

public class GetAtendimentoQuery : IRequest<IEnumerable<Atendimento>>
{

}
