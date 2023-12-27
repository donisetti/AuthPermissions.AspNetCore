using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("GRAFICA_SERVICOS_ITENS")]
public partial class GraficaServicosIten
{
    [Key]
    [Column("GRAFSI_Codigo")]
    public short GrafsiCodigo { get; set; }

    [Column("GRAFSI_Descricao")]
    [StringLength(20)]
    [Unicode(false)]
    public string? GrafsiDescricao { get; set; }
}
