using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("CAIXA_LANCAMENTO")]
[Index("CxoCodigo", Name = "index_CXO_CODIGO")]
public partial class CaixaLancamento
{
    [Key]
    [Column("CXL_Codigo")]
    public long CxlCodigo { get; set; }

    [Column("CXL_ValorLancamento", TypeName = "decimal(15, 2)")]
    public decimal? CxlValorLancamento { get; set; }

    [Column("CXL_DataLancamento", TypeName = "datetime")]
    public DateTime? CxlDataLancamento { get; set; }

    [Column("CXC_Codigo")]
    public int? CxcCodigo { get; set; }

    [Column("CXL_Historico")]
    [StringLength(80)]
    [Unicode(false)]
    public string? CxlHistorico { get; set; }

    [Column("CXL_NumeroDocumento")]
    public long CxlNumeroDocumento { get; set; }

    [Column("PCT_CodigoReduzido")]
    public int? PctCodigoReduzido { get; set; }

    [Column("CXO_CODIGO")]
    public int? CxoCodigo { get; set; }

    [ForeignKey("CxoCodigo")]
    [InverseProperty("CaixaLancamentos")]
    public virtual CaixaOperador? CxoCodigoNavigation { get; set; }

    [ForeignKey("PctCodigoReduzido")]
    [InverseProperty("CaixaLancamentos")]
    public virtual PlanoConta? PctCodigoReduzidoNavigation { get; set; }
}
