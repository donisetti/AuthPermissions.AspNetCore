using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("ESTADO")]
public partial class Estado
{
    [Key]
    [Column("EST_Codigo")]
    public short EstCodigo { get; set; }

    [Column("EST_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string EstDescricao { get; set; } = null!;

    [Column("EST_Sigla")]
    [StringLength(2)]
    [Unicode(false)]
    public string? EstSigla { get; set; }

    [Column("EST_FCP_AliqPadrao", TypeName = "decimal(15, 2)")]
    public decimal? EstFcpAliqPadrao { get; set; }
}
