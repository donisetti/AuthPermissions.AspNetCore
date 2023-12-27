using Facil.Dominio.Entidades.Agenda;
using MediatR;

namespace Facil.Aplicacao.CQRS.Agendamentos.Commands;

internal class AgendamentoRemoveCommand : IRequest<Appointment>
{
    public int Id { get; set; }

    public AgendamentoRemoveCommand(int id)
    {
        Id = id;
    }
}
