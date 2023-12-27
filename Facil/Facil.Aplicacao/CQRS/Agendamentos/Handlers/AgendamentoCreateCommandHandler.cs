using Facil.Aplicacao.CQRS.Agendamentos.Commands;
using Facil.Dominio.Entidades;
using Facil.Dominio.Entidades.Agenda;
using Facil.Dominio.Interfaces;
using MediatR;

namespace Facil.Aplicacao.CQRS.Agendamentos.Handlers;

public class AgendamentoCreateCommandHandler : IRequestHandler<AgendamentoCreateCommand, Appointment>
{
    private readonly IAgendamentoRepository _agendamentoRepository;

    public AgendamentoCreateCommandHandler(IAgendamentoRepository agendamentoRepository)
    {
        _agendamentoRepository = agendamentoRepository;
    }

    public async Task<Appointment> Handle(AgendamentoCreateCommand request, CancellationToken cancellationToken)
    {
        var agendamento = new Appointment(request.Id, request.ClienteId, request.FuncionarioId, request.EventStatus, request.Start, request.End, request.Color, request.AllDay, request.Other_details);


        //var atendimento = new Atendimento(request.ID, request.DataAtendimento, request.Descricao, request.Valor, request.DataPagamento, request.Observacao, request.ClienteId);


        if (agendamento == null)
        {
            throw new ApplicationException($"Error creating entity.");
        }
        else
        {
            //cliente.CategoryId = request.CategoryId;
            return await _agendamentoRepository.CreateAsync(agendamento);
        }
    }
}
