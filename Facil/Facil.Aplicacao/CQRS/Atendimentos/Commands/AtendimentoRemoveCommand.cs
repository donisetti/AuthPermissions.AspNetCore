using Facil.Dominio.Entidades;
using MediatR;

namespace Facil.Aplicacao.CQRS.Atendimentos.Commands;

public class AtendimentoRemoveCommand : IRequest<Atendimento>
{
    public Guid Id { get; set; }
    public AtendimentoRemoveCommand(Guid id)
    {
        Id = id;
    }   
}
