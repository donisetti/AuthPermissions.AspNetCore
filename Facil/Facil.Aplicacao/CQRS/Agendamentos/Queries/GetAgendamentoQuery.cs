using Facil.Dominio.Entidades.Agenda;
using MediatR;

namespace Facil.Aplicacao.CQRS.Agendamentos.Queries;

public class GetAgendamentoQuery : IRequest<IEnumerable<Appointment>>
{
}
