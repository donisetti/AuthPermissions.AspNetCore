using AutoMapper;
using Facil.Aplicacao.DTOs;
using Facil.Aplicacao.CQRS.Agendamentos.Commands;
using Facil.Aplicacao.CQRS.Atendimentos.Commands;
using Facil.Aplicacao.CQRS.Clientes.Commands;
using Facil.Aplicacao.CQRS.Funcionarios.Commands;

namespace Facil.Aplicacao.Mappings;

public class DTOToCommandMappingProfile : Profile
{
    public DTOToCommandMappingProfile()
    {
        // >>>>>>>>>>>>>> Create       
        CreateMap<ClienteDTO, ClienteCreateCommand>();
        CreateMap<FuncionarioDTO, FuncionarioCreateCommand>();
        CreateMap<AtendimentoDTO, AtendimentoCreateCommand>();
        CreateMap<AppointmentDTO, AgendamentoCreateCommand>();

        // >>>>>>>>>>>>>> Update        
        CreateMap<ClienteDTO, ClienteUpdateCommand>();
        CreateMap<FuncionarioDTO, FuncionarioUpdateCommand>();
        CreateMap<AtendimentoDTO, AtendimentoUpdateCommand>();
        CreateMap<AppointmentDTO, AgendamentoUpdateCommand>();
    }
}
