using Facil.Aplicacao.CQRS.Atendimentos.Commands;
using Facil.Dominio.Entidades;
using Facil.Dominio.Interfaces;
using MediatR;

namespace Facil.Aplicacao.CQRS.Atendimentos.Handlers;

public class AtendimentoRemoveCommandHandler : IRequestHandler<AtendimentoRemoveCommand, Atendimento>
{
    private readonly IAtendimentoRepository _atendimentoRepository;

    public AtendimentoRemoveCommandHandler(IAtendimentoRepository atendimentoRepository)
    {
        _atendimentoRepository = atendimentoRepository;
    }

    public async Task<Atendimento> Handle(AtendimentoRemoveCommand request, CancellationToken cancellationToken)
    {
        var atendimento = await _atendimentoRepository.GetByIdAsync(request.Id);

        if (atendimento == null)
        {
            throw new ApplicationException($"Atendimento não pode ser encontrado.");
        }
        else
        {
            var result = await _atendimentoRepository.RemoveAsync(atendimento);
            return result;
        }
    }
}
