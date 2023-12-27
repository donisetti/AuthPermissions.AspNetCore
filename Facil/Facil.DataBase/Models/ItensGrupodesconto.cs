using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("ITENS_GRUPODESCONTO")]
public partial class ItensGrupodesconto
{
    [Key]
    [Column("IGPD_Codigo")]
    public int IgpdCodigo { get; set; }

    [Column("GPD_Codigo")]
    public int GpdCodigo { get; set; }

    [Column("PRO_Codigo")]
    public int ProCodigo { get; set; }

    [Column("IGPD_PctDesconto", TypeName = "decimal(15, 4)")]
    public decimal? IgpdPctDesconto { get; set; }
}
