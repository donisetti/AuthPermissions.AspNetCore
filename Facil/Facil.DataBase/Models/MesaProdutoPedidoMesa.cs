using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("MESA_PRODUTO_PEDIDO_MESA")]
public partial class MesaProdutoPedidoMesa
{
    [Key]
    [Column("MPP_Codigo")]
    public int MppCodigo { get; set; }

    [Column("PPZ_Codigo")]
    public short PpzCodigo { get; set; }

    [Column("MPP_Item")]
    public int? MppItem { get; set; }

    [Column("PRO_Codigo")]
    public int? ProCodigo { get; set; }

    [Column("PRO_Cod_Barra")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ProCodBarra { get; set; }

    [Column("PRO_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProDescricao { get; set; }

    [Column("PRO_Quantidade", TypeName = "decimal(10, 3)")]
    public decimal? ProQuantidade { get; set; }

    [Column("UNI_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string? UniDescricao { get; set; }

    [Column("PRO_ValorVendaUnitario", TypeName = "decimal(15, 2)")]
    public decimal? ProValorVendaUnitario { get; set; }

    [Column("PRO_Vlr_SubTotal", TypeName = "decimal(15, 2)")]
    public decimal? ProVlrSubTotal { get; set; }

    [Column("PRO_ValorDescontoProduto", TypeName = "decimal(15, 2)")]
    public decimal? ProValorDescontoProduto { get; set; }

    [Column("PRO_Porc_Desconto", TypeName = "decimal(15, 2)")]
    public decimal? ProPorcDesconto { get; set; }

    [Column("MPP_Total", TypeName = "decimal(15, 2)")]
    public decimal? MppTotal { get; set; }

    [Column("MPP_Cancelado")]
    public bool? MppCancelado { get; set; }

    [ForeignKey("PpzCodigo")]
    [InverseProperty("MesaProdutoPedidoMesas")]
    public virtual MesaPedido PpzCodigoNavigation { get; set; } = null!;
}
