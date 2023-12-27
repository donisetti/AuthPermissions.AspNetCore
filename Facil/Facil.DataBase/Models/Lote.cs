using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[PrimaryKey("LotDataVencimento", "ProCodigo")]
[Table("LOTE")]
public partial class Lote
{
    [Key]
    [Column("PRO_Codigo")]
    public int ProCodigo { get; set; }

    [Key]
    [Column("LOT_DataVencimento", TypeName = "smalldatetime")]
    public DateTime LotDataVencimento { get; set; }

    [Column("LOT_QtdeEstoque", TypeName = "decimal(10, 3)")]
    public decimal LotQtdeEstoque { get; set; }

    [ForeignKey("ProCodigo")]
    [InverseProperty("Lotes")]
    public virtual Produto ProCodigoNavigation { get; set; } = null!;
}
