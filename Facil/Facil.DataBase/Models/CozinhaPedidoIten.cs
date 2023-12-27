using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("COZINHA_PEDIDO_ITENS")]
public partial class CozinhaPedidoIten
{
    [Key]
    [Column("ICOZ_Codigo")]
    public int IcozCodigo { get; set; }

    [Column("COZ_Codigo")]
    public int? CozCodigo { get; set; }

    [Column("PRO_Codigo")]
    public int? ProCodigo { get; set; }

    [Column("ICOZ_Quantidade", TypeName = "decimal(15, 4)")]
    public decimal? IcozQuantidade { get; set; }

    [Column("ICOZ_ValorUnitario", TypeName = "decimal(15, 4)")]
    public decimal? IcozValorUnitario { get; set; }

    [Column("ICOZ_Obs")]
    [StringLength(100)]
    [Unicode(false)]
    public string? IcozObs { get; set; }
}
