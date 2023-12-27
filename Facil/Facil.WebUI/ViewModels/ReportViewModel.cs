using FastReport.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Facil.WebUI.ViewModels;

public class ReportViewModel
{
    public WebReport WebReport { get; set; }

    [DisplayName("Cliente")]
    public Guid ClienteId { get; set; }

    //[DisplayName("Atendimento")]
    //public Guid AtendimentoId { get; set; }    
    
    [Required(ErrorMessage = "A Data Inicial é Obrigatória")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    [DataType(DataType.Date)]
    [DisplayName("Data Inicial")]
    public DateTime DataInicio { get; set; }

    [Required(ErrorMessage = "A Data Final é Obrigatória")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    [DataType(DataType.Date)]
    [DisplayName("Data Final")]
    public DateTime DataFim { get; set; }


    public string FiltroData { get; set; }

    public string Tipo { get; set; } = "Venda";
}