using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("RESTBAR_PEDIDO")]
public partial class RestbarPedido
{
    [Key]
    [Column("RBP_CODIGO")]
    public short RbpCodigo { get; set; }

    [Column("RBT_CODIGO")]
    public short? RbtCodigo { get; set; }

    [Column("RBP_Numeracao")]
    public short? RbpNumeracao { get; set; }

    [Column("RBP_Enviado_Cozinha")]
    public bool? RbpEnviadoCozinha { get; set; }

    [Column("RBP_Pedido_Aberto")]
    public bool? RbpPedidoAberto { get; set; }

    [Column("PES_Codigo")]
    public int? PesCodigo { get; set; }

    [Column("FIS_Nome")]
    [StringLength(100)]
    [Unicode(false)]
    public string? FisNome { get; set; }

    [Column("RBP_Status")]
    [StringLength(9)]
    [Unicode(false)]
    public string? RbpStatus { get; set; }
}
