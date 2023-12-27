using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("DEVOLUCAO_ITEM")]
public partial class DevolucaoItem
{
    [Key]
    [Column("DVI_Codigo")]
    public int DviCodigo { get; set; }

    [Column("DEV_Codigo")]
    public int? DevCodigo { get; set; }

    [Column("DVI_Quantidade", TypeName = "decimal(10, 3)")]
    public decimal? DviQuantidade { get; set; }

    [Column("DVI_ValorUnitario", TypeName = "decimal(15, 2)")]
    public decimal? DviValorUnitario { get; set; }

    [Column("DVI_DescontoItemPct", TypeName = "decimal(15, 2)")]
    public decimal? DviDescontoItemPct { get; set; }

    [Column("PRO_Codigo")]
    public int? ProCodigo { get; set; }

    [ForeignKey("DevCodigo")]
    [InverseProperty("DevolucaoItems")]
    public virtual Devolucao? DevCodigoNavigation { get; set; }

    [ForeignKey("ProCodigo")]
    [InverseProperty("DevolucaoItems")]
    public virtual Produto? ProCodigoNavigation { get; set; }
}
