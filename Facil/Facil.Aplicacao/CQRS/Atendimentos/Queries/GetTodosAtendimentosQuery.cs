using Facil.Dominio.Entidades;
using MediatR;

namespace Facil.Aplicacao.CQRS.Atendimentos.Queries;

public class GetTodosAtendimentosQuery : IRequest<IEnumerable<Atendimento>>
{
    public Guid Id { get; set; }
    public Guid ClienteId { get; set; }   
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public string FiltroData { get; set; } = "DataAtendimento";


    public GetTodosAtendimentosQuery()
    {
        Id = Guid.Empty;
        ClienteId = Guid.Empty;   
        var hoje = DateTime.UtcNow;
        var primeiroDia = new DateTime(hoje.Year, hoje.Month, 1);
        var diasMes = DateTime.DaysInMonth(hoje.Year, hoje.Month);
        var ultimoDia = new DateTime(hoje.Year, hoje.Month, diasMes);
        DataInicio = primeiroDia;
        DataFim = ultimoDia;
    }

    public GetTodosAtendimentosQuery(Guid clienteId, DateTime dataInicio, DateTime dataFim, string filtroData)
    {
        Id = Guid.Empty;
        ClienteId = clienteId;
        DataInicio = dataInicio;
        DataFim = dataFim;
        FiltroData = filtroData;
    }
}
