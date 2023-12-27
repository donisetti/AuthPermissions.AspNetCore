using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Facil.Dominio.Enums;

public enum AppointmentStatus
{
    /// <summary>
    /// Indicates an unidentified value.
    /// </summary>   
    None = 0,
    /// <summary>
    /// Indicates DoctorEvent Planned.
    /// </summary>
    [Display(Name = "Agendado")]
    Agendado = 1,

    /// <summary>
    /// Aguardando
    /// </summary>
    [Display(Name = "Aguardando")]
    Aguardando = 2,

    /// <summary>
    /// Cancelado
    /// </summary>
    [Display(Name = "Cancelado")]
    Cancelado = 3,

    /// <summary>
    ///Completo
    /// </summary>
    [Display(Name = "Completo")]
    Completo = 4,

    /// <summary>
    /// Indicates DoctorEvent Completed.
    /// </summary>
    [Display(Name = "Atrasado")]
    Atrasado = 5


}
