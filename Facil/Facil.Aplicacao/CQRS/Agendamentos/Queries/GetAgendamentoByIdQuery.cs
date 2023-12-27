using Facil.Dominio.Entidades.Agenda;
using MediatR;

namespace Facil.Aplicacao.CQRS.Agendamentos.Queries
{
    public class GetAgendamentoByIdQuery : IRequest<Appointment>
    {
        public GetAgendamentoByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
