using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("RESTBAR_PEDIDO_PRODUTO")]
public partial class RestbarPedidoProduto
{
    [Key]
    [Column("RBPP_Codigo")]
    public int RbppCodigo { get; set; }

    [Column("RBP_CODIGO")]
    public short RbpCodigo { get; set; }

    [Column("RBPP_Item")]
    public int? RbppItem { get; set; }

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

    [Column("RBPP_Total", TypeName = "decimal(15, 2)")]
    public decimal? RbppTotal { get; set; }

    [Column("RBPP_Cancelado")]
    public bool? RbppCancelado { get; set; }

    [Column("RBPP_Faturado")]
    public bool? RbppFaturado { get; set; }

    [Column("RBPP_EnviadoCozinha")]
    public bool? RbppEnviadoCozinha { get; set; }
}
