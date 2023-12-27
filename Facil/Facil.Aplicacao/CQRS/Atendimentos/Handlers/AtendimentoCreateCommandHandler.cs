using Facil.Aplicacao.CQRS.Atendimentos.Commands;
using Facil.Dominio.Entidades;
using Facil.Dominio.Interfaces;
using MediatR;

namespace Facil.Aplicacao.CQRS.Atendimentos.Handlers;

public class AtendimentoCreateCommandHandler : IRequestHandler<AtendimentoCreateCommand, Atendimento>
{
    private readonly IAtendimentoRepository _atendimentoRepository;

    public AtendimentoCreateCommandHandler(IAtendimentoRepository atendimentoRepository)
    {
        _atendimentoRepository = atendimentoRepository;
    }

    public async Task<Atendimento> Handle(AtendimentoCreateCommand request, CancellationToken cancellationToken)
    {
        var atendimento = new Atendimento(request.ID, request.DataAtendimento, request.Descricao, request.Valor, request.DataPagamento, request.Observacao, request.ClienteId);

        if (atendimento == null)
        {
            throw new ApplicationException($"Error creating entity.");
        }
        else
        {
            //cliente.CategoryId = request.CategoryId;
            return await _atendimentoRepository.CreateAsync(atendimento);
        }
    }
}
