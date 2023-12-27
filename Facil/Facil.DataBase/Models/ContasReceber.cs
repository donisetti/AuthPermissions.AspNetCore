using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("CONTAS_RECEBER")]
public partial class ContasReceber
{
    [Key]
    [Column("CRE_Codigo")]
    public int CreCodigo { get; set; }

    [Column("CRE_ValorPagamento", TypeName = "decimal(15, 2)")]
    public decimal? CreValorPagamento { get; set; }

    [Column("CRE_DataVencimento", TypeName = "smalldatetime")]
    public DateTime? CreDataVencimento { get; set; }

    [Column("CRE_DataEmCobranca", TypeName = "smalldatetime")]
    public DateTime? CreDataEmCobranca { get; set; }

    [Column("CRE_ValorAbatido", TypeName = "decimal(15, 2)")]
    public decimal? CreValorAbatido { get; set; }

    [Column("CRE_ValorBruto", TypeName = "decimal(15, 2)")]
    public decimal? CreValorBruto { get; set; }

    [Column("CRE_DataAbatimento", TypeName = "smalldatetime")]
    public DateTime? CreDataAbatimento { get; set; }

    [Column("CRE_Situacao")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CreSituacao { get; set; }

    [Column("CRE_DataRecebimento", TypeName = "smalldatetime")]
    public DateTime? CreDataRecebimento { get; set; }

    [Column("CRE_ValorJurosAbatidos", TypeName = "decimal(15, 2)")]
    public decimal? CreValorJurosAbatidos { get; set; }

    [Column("CRE_ValorJurosRestantes", TypeName = "decimal(15, 2)")]
    public decimal? CreValorJurosRestantes { get; set; }

    [Column("VDA_ValorCredito", TypeName = "decimal(15, 2)")]
    public decimal? VdaValorCredito { get; set; }

    [Column("CRE_ParcelaTexto")]
    [StringLength(7)]
    [Unicode(false)]
    public string? CreParcelaTexto { get; set; }

    [Column("CRE_ValorDescontoRecebimento", TypeName = "decimal(15, 2)")]
    public decimal? CreValorDescontoRecebimento { get; set; }

    [Column("CRE_PctDescontoRecebimento", TypeName = "decimal(15, 2)")]
    public decimal? CrePctDescontoRecebimento { get; set; }

    [Column("CRE_DataEstorno", TypeName = "smalldatetime")]
    public DateTime? CreDataEstorno { get; set; }

    [Column("CRE_UsuarioEstorno")]
    public short? CreUsuarioEstorno { get; set; }

    [Column("USU_Codigo")]
    public int? UsuCodigo { get; set; }

    [Column("USU_Codigo_Desconto")]
    public int? UsuCodigoDesconto { get; set; }

    [Column("VDA_Codigo")]
    public long VdaCodigo { get; set; }

    [Column("PES_CODIGO")]
    public int? PesCodigo { get; set; }

    [InverseProperty("CreCodigoNavigation")]
    public virtual ICollection<ContasRecebimento> ContasRecebimentos { get; set; } = new List<ContasRecebimento>();

    [ForeignKey("PesCodigo")]
    [InverseProperty("ContasRecebers")]
    public virtual Pessoa? PesCodigoNavigation { get; set; }

    [ForeignKey("VdaCodigo")]
    [InverseProperty("ContasRecebers")]
    public virtual Vendum VdaCodigoNavigation { get; set; } = null!;
}
