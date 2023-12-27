using System.ComponentModel.DataAnnotations;

namespace Facil.WebUI.ViewModels;

public class EventoViewModel
{
    public int id { get; set; }
    public int idgroupId { get; set; }
    public string title { get; set; }

    public string color { get; set; } = "Green";
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "dd/MM/yyyy HH:mm", ApplyFormatInEditMode = false)]
    public DateTime start { get; set; } = DateTime.UtcNow.AddHours(1);
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "dd/MM/yyyy HH:mm", ApplyFormatInEditMode = false)]
    public DateTime end { get; set; } = DateTime.UtcNow.AddMinutes(30);
    public string url { get; set; } = string.Empty;
    public bool allday { get; set; } = false;
    public bool editable { get; set; } = true;

    public Guid clienteId { get; set; } = Guid.Empty;
    public string nomeCliente { get; set; } = string.Empty;

    public Guid pessoaId { get; set; } = Guid.Empty;
    public string nomePessoa { get; set; } = string.Empty;

    public string description { get; set; } = string.Empty;
    public string user { get; set; } = string.Empty;
}
