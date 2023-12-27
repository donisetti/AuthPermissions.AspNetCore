using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[PrimaryKey("VdaCodigo", "ProCodigo", "LotDataVencimento")]
[Table("VENDA_LOTE")]
public partial class VendaLote
{
    [Key]
    [Column("VDA_Codigo")]
    public long VdaCodigo { get; set; }

    [Key]
    [Column("PRO_Codigo")]
    public int ProCodigo { get; set; }

    [Key]
    [Column("LOT_DataVencimento", TypeName = "smalldatetime")]
    public DateTime LotDataVencimento { get; set; }

    [Column("LOT_QtdeEstoque", TypeName = "decimal(10, 3)")]
    public decimal LotQtdeEstoque { get; set; }

    [ForeignKey("ProCodigo")]
    [InverseProperty("VendaLotes")]
    public virtual Produto ProCodigoNavigation { get; set; } = null!;
}
