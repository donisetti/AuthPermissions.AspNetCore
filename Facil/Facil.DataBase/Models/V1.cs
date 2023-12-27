using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Keyless]
public partial class V1
{
    [Column("PAGAMENTO")]
    [StringLength(13)]
    [Unicode(false)]
    public string Pagamento { get; set; } = null!;

    [Column("VDA_Codigo")]
    public long VdaCodigo { get; set; }

    [Column("VDA_Valor", TypeName = "decimal(15, 2)")]
    public decimal? VdaValor { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? Valor { get; set; }

    [Column("FPG_Codigo")]
    public short? FpgCodigo { get; set; }

    [Column("PCT_CodigoReduzido")]
    public int? PctCodigoReduzido { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string CodigoEstorno { get; set; } = null!;

    [Column("cre_codigo")]
    public int CreCodigo { get; set; }

    [Column("VENCIMENTO", TypeName = "smalldatetime")]
    public DateTime? Vencimento { get; set; }

    [Column("RECEBIDO")]
    [StringLength(8)]
    [Unicode(false)]
    public string? Recebido { get; set; }
}
