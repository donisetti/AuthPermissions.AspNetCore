using Facil.Dominio.Entidades.DadosPessoa;
using Facil.Dominio.Enums;

namespace Facil.Dominio.Entidades.Agenda;

public class Appointment
{
    public int Id { get; set; }
    public string? Subject { get; set; } = string.Empty;

    public Guid ClienteId { get; set; }
    public string? NomeCliente { get; set; } = string.Empty;
    public Guid FuncionarioId { get; set; }
    public string? NomeFuncionario { get; set; } = string.Empty;

    public AppointmentStatus EventStatus { get; set; }

    public DateTime Start { get; set; }
    public DateTime? End { get; set; }
    public string? Color { get; set; }
    public Boolean AllDay { get; set; }

    public string Other_details { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;

    public Cliente? Cliente { get; set; }
    public Funcionario? Funcionario { get; set; }


    /// <summary>
    /// Gets or sets the date and time the object was last created.
    /// </summary>
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Gets or sets the date and time the object was last modified.
    /// </summary>
    /// 
    public DateTime DateModified { get; set; } = DateTime.UtcNow;



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


    public Appointment(int id, Guid clienteId, Guid funcionarioId, AppointmentStatus eventStatus, DateTime start, DateTime? end, string? color, bool allDay, string other_details)
    {
        Id = id;
        ClienteId = clienteId;
        FuncionarioId = funcionarioId;
        EventStatus = eventStatus;
        Start = start;
        End = end;
        Color = color;
        AllDay = allDay;
        Other_details = other_details;

    }

    public Appointment(int id, Guid clienteId, Guid funcionarioId, AppointmentStatus eventStatus, DateTime start, DateTime? end, string? color, bool allDay, string other_details, string? subject, string? sescription, string location, string title)
    {
        Id = id;
        Subject = subject;
        ClienteId = clienteId;
        FuncionarioId = funcionarioId;
        EventStatus = eventStatus;
        Subject = subject;
        Start = start;
        End = end;
        Color = color;
        AllDay = allDay;
        Other_details = other_details;
        Title = title;
        Location = location;
        Description = Description;

    }

    public void Update(int id, Guid clienteId, Guid funcionarioId, AppointmentStatus eventStatus, DateTime start, DateTime? end, string? color, bool allDay, string other_details, string? subject, string description, string location, string title)
    {
        Id = id;
        Subject = subject;
        ClienteId = clienteId;
        FuncionarioId = funcionarioId;
        EventStatus = eventStatus;
        Start = start;
        End = end;
        Color = color;
        AllDay = allDay;
        Other_details = other_details;
        Title = title;
        Location = location;
        Description = description;
    }
}
