using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Keyless]
public partial class VBmpo
{
    [Column("SUB_DCB")]
    [StringLength(10)]
    [Unicode(false)]
    public string? SubDcb { get; set; }

    [Column("SUB_Descricao")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SubDescricao { get; set; }

    [Column("PRO_Descricao")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ProDescricao { get; set; }

    [Column("PRO_Apresentacao")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ProApresentacao { get; set; }

    [Column("INICIAL")]
    public int? Inicial { get; set; }

    [Column("ENTRADA")]
    public int? Entrada { get; set; }

    [Column("SAIDA")]
    public int? Saida { get; set; }

    [Column("PERDA")]
    public int? Perda { get; set; }

    [Column("FINAL")]
    public short? Final { get; set; }

    [Column("DATA", TypeName = "smalldatetime")]
    public DateTime? Data { get; set; }

    [Column("PRO_CODIGO")]
    public int ProCodigo { get; set; }
}
