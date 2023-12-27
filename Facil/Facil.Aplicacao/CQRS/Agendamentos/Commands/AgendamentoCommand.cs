using Facil.Dominio.Entidades.Agenda;
using Facil.Dominio.Entidades.DadosPessoa;
using Facil.Dominio.Enums;
using MediatR;

namespace Facil.Aplicacao.CQRS.Agendamentos.Commands;

public class AgendamentoCommand : IRequest<Appointment>
{
    public int Id { get; set; }
    public string? Subject { get; set; } = string.Empty;

    public Cliente? Cliente { get; set; }
    public Guid ClienteId { get; set; }

    public Funcionario? Funcionario { get; set; }
    public Guid FuncionarioId { get; set; }


    public AppointmentStatus EventStatus { get; set; }


    public DateTime Start { get; set; }
    public DateTime? End { get; set; }
    public string? Color { get; set; }
    public Boolean AllDay { get; set; }


    /// <summary>
    /// Gets or sets the date and time the object was last created.
    /// </summary>
    public DateTime DateCreated { get; set; }

    /// <summary>
    /// Gets or sets the date and time the object was last modified.
    /// </summary>
    /// 
    public DateTime DateModified { get; set; }

    public string Other_details { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;


    /// <summary>
    /// Gets the Number of the booking.
    /// </summary>
    public string BookingNumber
    {
        get
        {
            string temp = DateCreated.ToLongTimeString() ?? string.Empty;
            if (!string.IsNullOrEmpty(FuncionarioId.ToString()) &&
                !string.IsNullOrEmpty(ClienteId.ToString()))
            {

                if (temp.Length > 0)
                {
                    temp += "-";
                }
                temp += FuncionarioId.ToString() + "/" + ClienteId.ToString();
            }
            return temp.Replace(":", "");
        }
    }


}
