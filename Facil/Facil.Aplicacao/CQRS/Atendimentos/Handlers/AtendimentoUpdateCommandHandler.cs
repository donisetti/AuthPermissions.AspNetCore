using Facil.Aplicacao.CQRS.Atendimentos.Commands;
using Facil.Dominio.Entidades;
using Facil.Dominio.Interfaces;
using MediatR;

namespace Facil.Aplicacao.CQRS.Atendimentos.Handlers;

public class AtendimentoUpdateCommandHandler : IRequestHandler<AtendimentoUpdateCommand, Atendimento>
{
    private readonly IAtendimentoRepository _atendimentoRepository;

    public AtendimentoUpdateCommandHandler(IAtendimentoRepository atendimentoRepository)
    {
        _atendimentoRepository = atendimentoRepository;
    }

    public async Task<Atendimento> Handle(AtendimentoUpdateCommand request, CancellationToken cancellationToken)
    {
        var atendimento = await _atendimentoRepository.GetByIdAsync(request.Id);

        if (atendimento == null)
        {
            throw new ApplicationException($"Entity could not be found.");
        }
        else
        {            
            atendimento.Update(request.DataAtendimento, request.Descricao, request.Valor, request.DataPagamento, request.Observacao, request.ClienteId);

            return await _atendimentoRepository.UpdateAsync(atendimento);

        }
    }
}
