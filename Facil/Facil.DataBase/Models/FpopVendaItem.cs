using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("FPOP_VENDA_ITEM")]
public partial class FpopVendaItem
{
    [Key]
    [Column("FPOI_Codigo")]
    public long FpoiCodigo { get; set; }

    [Column("PRO_Codigo")]
    public int? ProCodigo { get; set; }

    [Column("FPOI_qtAutorizada", TypeName = "decimal(10, 3)")]
    public decimal? FpoiQtAutorizada { get; set; }

    [Column("FPOI_CodigoBarras")]
    [StringLength(14)]
    [Unicode(false)]
    public string? FpoiCodigoBarras { get; set; }

    [Column("FPOI_vlPrecoVenda", TypeName = "decimal(15, 2)")]
    public decimal? FpoiVlPrecoVenda { get; set; }

    [Column("FPOI_vlPrecoSubsidiadoMS", TypeName = "decimal(15, 2)")]
    public decimal? FpoiVlPrecoSubsidiadoMs { get; set; }

    [Column("FPOV_Codigo")]
    public long? FpovCodigo { get; set; }

    [Column("FPOI_vlPrecoSubsidiadoPaciente", TypeName = "decimal(15, 2)")]
    public decimal? FpoiVlPrecoSubsidiadoPaciente { get; set; }

    [Column("FPOI_Estorno", TypeName = "smalldatetime")]
    public DateTime? FpoiEstorno { get; set; }

    [Column("FPOI_nuEstorno")]
    [StringLength(30)]
    [Unicode(false)]
    public string? FpoiNuEstorno { get; set; }

    [Column("FPOI_qtVendida", TypeName = "decimal(10, 3)")]
    public decimal? FpoiQtVendida { get; set; }

    [ForeignKey("FpovCodigo")]
    [InverseProperty("FpopVendaItems")]
    public virtual FpopVendum? FpovCodigoNavigation { get; set; }
}
