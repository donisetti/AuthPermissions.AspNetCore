using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("FPOP_VENDA")]
public partial class FpopVendum
{
    [Key]
    [Column("FPOV_Codigo")]
    public long FpovCodigo { get; set; }

    [Column("FPOV_DataLancamento", TypeName = "smalldatetime")]
    public DateTime? FpovDataLancamento { get; set; }

    [Column("FPOV_Autorizacao")]
    [StringLength(30)]
    [Unicode(false)]
    public string? FpovAutorizacao { get; set; }

    [Column("FPOV_NomePaciente")]
    [StringLength(80)]
    [Unicode(false)]
    public string? FpovNomePaciente { get; set; }

    [Column("FPOV_Cpf")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FpovCpf { get; set; }

    [Column("FPOV_CupomFiscal")]
    public long? FpovCupomFiscal { get; set; }

    [Column("FPOV_CupomVinculado")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? FpovCupomVinculado { get; set; }

    [Column("FPOV_CodigoRetorno")]
    [StringLength(5)]
    [Unicode(false)]
    public string? FpovCodigoRetorno { get; set; }

    [Column("FPOV_Status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? FpovStatus { get; set; }

    [Column("FPOV_inAutorizacaoSolicitacao")]
    [StringLength(5)]
    [Unicode(false)]
    public string? FpovInAutorizacaoSolicitacao { get; set; }

    [Column("VDA_Codigo")]
    public long? VdaCodigo { get; set; }

    [InverseProperty("FpovCodigoNavigation")]
    public virtual ICollection<FpopVendaItem> FpopVendaItems { get; set; } = new List<FpopVendaItem>();
}
