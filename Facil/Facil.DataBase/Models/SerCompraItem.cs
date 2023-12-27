using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("SER_COMPRA_ITEM")]
public partial class SerCompraItem
{
    [Key]
    [Column("COI_Codigo")]
    public int CoiCodigo { get; set; }

    [Column("COI_Quantidade", TypeName = "decimal(10, 3)")]
    public decimal? CoiQuantidade { get; set; }

    [Column("COI_ValorCustoCompra", TypeName = "decimal(15, 3)")]
    public decimal? CoiValorCustoCompra { get; set; }

    [Column("COM_Codigo")]
    public int? ComCodigo { get; set; }

    [Column("PRO_Codigo")]
    public int? ProCodigo { get; set; }

    [ForeignKey("ComCodigo")]
    [InverseProperty("SerCompraItems")]
    public virtual SerCompra? ComCodigoNavigation { get; set; }

    [ForeignKey("ProCodigo")]
    [InverseProperty("SerCompraItems")]
    public virtual Produto? ProCodigoNavigation { get; set; }
}
