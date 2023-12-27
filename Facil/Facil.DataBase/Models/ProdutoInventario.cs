using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[PrimaryKey("ProCodigo", "ProLote")]
[Table("PRODUTO_INVENTARIO")]
public partial class ProdutoInventario
{
    [Key]
    [Column("PRO_Codigo")]
    public int ProCodigo { get; set; }

    [Key]
    [Column("PRO_Lote")]
    [StringLength(30)]
    [Unicode(false)]
    public string ProLote { get; set; } = null!;

    [Column("PRO_Quantidade")]
    public short ProQuantidade { get; set; }

    [Column("PRO_EstoqueInicial")]
    public short? ProEstoqueInicial { get; set; }

    [Column("PRO_DataEntradaInventario", TypeName = "smalldatetime")]
    public DateTime? ProDataEntradaInventario { get; set; }

    [Column("PRO_RegistroMSInventario")]
    [StringLength(13)]
    [Unicode(false)]
    public string? ProRegistroMsinventario { get; set; }

    [ForeignKey("ProCodigo")]
    [InverseProperty("ProdutoInventarios")]
    public virtual Produto ProCodigoNavigation { get; set; } = null!;
}
