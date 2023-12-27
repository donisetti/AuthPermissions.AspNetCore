using AutoMapper;
using Facil.Aplicacao.DTOs;
using Facil.Dominio.Entidades;
using Facil.Dominio.Entidades.Agenda;
using Facil.Dominio.Entidades.DadosPessoa;

namespace Facil.Aplicacao.Mappings;

public class DomainToDTOMappingProfile : Profile
{
    public DomainToDTOMappingProfile()
    {
        CreateMap<Cliente, ClienteDTO>().ReverseMap();
        CreateMap<Funcionario, FuncionarioDTO>().ReverseMap();
        CreateMap<Atendimento, AtendimentoDTO>().ReverseMap();
        CreateMap<Appointment, AppointmentDTO>().ReverseMap();
    }
}