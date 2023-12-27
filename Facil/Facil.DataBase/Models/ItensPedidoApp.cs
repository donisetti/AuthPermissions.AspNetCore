using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[PrimaryKey("PedCodigo", "PeiCodigo", "VenCodigo")]
[Table("ITENS_PEDIDO_APP")]
public partial class ItensPedidoApp
{
    [Key]
    [Column("PED_Codigo")]
    public int PedCodigo { get; set; }

    [Key]
    [Column("PEI_Codigo")]
    public int PeiCodigo { get; set; }

    [Key]
    [Column("VEN_Codigo")]
    public int VenCodigo { get; set; }

    [Column("PEI_Quantidade", TypeName = "decimal(5, 3)")]
    public decimal? PeiQuantidade { get; set; }

    [Column("PRO_Codigo")]
    public int? ProCodigo { get; set; }

    [Column("PRO_Nome")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ProNome { get; set; }

    [Column("PEI_ValorProduto", TypeName = "decimal(15, 3)")]
    public decimal? PeiValorProduto { get; set; }

    [Column("PEI_DataEstorno", TypeName = "smalldatetime")]
    public DateTime? PeiDataEstorno { get; set; }
}
