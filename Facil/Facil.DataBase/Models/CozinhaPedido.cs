using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("COZINHA_PEDIDO")]
public partial class CozinhaPedido
{
    [Key]
    [Column("COZ_Codigo")]
    public int CozCodigo { get; set; }

    [Column("COZ_DataPedido", TypeName = "datetime")]
    public DateTime? CozDataPedido { get; set; }

    [Column("COZ_DataFechamento", TypeName = "datetime")]
    public DateTime? CozDataFechamento { get; set; }

    [Column("PES_Codigo")]
    public int? PesCodigo { get; set; }

    [Column("COZ_Solicitante")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CozSolicitante { get; set; }

    [Column("COZ_EnderecoEntrega")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CozEnderecoEntrega { get; set; }

    [Column("COZ_Obs")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CozObs { get; set; }

    [Column("VDA_Codigo")]
    public long? VdaCodigo { get; set; }

    [Column("COZ_ValorTroco", TypeName = "decimal(15, 2)")]
    public decimal? CozValorTroco { get; set; }
}
