using Facil.Dominio.Entidades.DadosPessoa;
using Facil.Dominio.Enums;
using System.ComponentModel.DataAnnotations;

namespace Facil.Aplicacao.DTOs;

public class AppointmentDTO
{
    public int Id { get; set; }

    [Display(Name = "Atividade")]
    public string? Subject { get; set; } = string.Empty;

    public Cliente? Cliente { get; set; }
    [Display(Name = "Cliente")]
    public Guid ClienteId { get; set; } = Guid.Empty;

    [Display(Name = "Nome do Cliente")]
    public string? NomeCliente { get; set; } = string.Empty;

    public Funcionario? Funcionario { get; set; }
    [Display(Name = "Funcionário")]
    public Guid FuncionarioId { get; set; } = Guid.Empty;

    [Display(Name = "Nome do Funcionário")]
    public string? NomeFuncionario { get; set; } = string.Empty;

    [Display(Name = "Situação")]
    public AppointmentStatus EventStatus { get; set; } = AppointmentStatus.Agendado;

    [Display(Name = "Início")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm:ss}")]
    public DateTime Start { get; set; }
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm:ss}")]
    [Display(Name = "Termino")]
    public DateTime? End { get; set; }
    [Display(Name = "Cor")]
    public string? Color { get; set; } = "Green";
    [Display(Name = "O dia Inteiro")]
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

    [Display(Name = "Observações")]
    public string Other_details { get; set; } = "Obs: ";

    [Display(Name = "Título")]
    public string Title { get; set; } = string.Empty;
    [Display(Name = "Descrição")]
    public string Description { get; set; } = string.Empty;
    [Display(Name = "Localização")]
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
