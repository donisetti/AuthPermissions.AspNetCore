using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("RESTBAR_TIPO")]
public partial class RestbarTipo
{
    [Key]
    [Column("RBT_CODIGO")]
    public short RbtCodigo { get; set; }

    [Column("RBT_TIPO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RbtTipo { get; set; }

    [Column("RBT_QTD_LINHA")]
    public short? RbtQtdLinha { get; set; }

    [Column("RBT_QTD_COLUNA")]
    public short? RbtQtdColuna { get; set; }

    [Column("RBT_USA_CONTROLE_ENTREGA")]
    public bool? RbtUsaControleEntrega { get; set; }

    [Column("RBT_TAXA_ENTREGA", TypeName = "decimal(15, 2)")]
    public decimal? RbtTaxaEntrega { get; set; }
}
