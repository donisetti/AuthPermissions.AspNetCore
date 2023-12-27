using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("CAIXA_OPERADOR")]
public partial class CaixaOperador
{
    [Key]
    [Column("CXO_Codigo")]
    public int CxoCodigo { get; set; }

    [Column("CXO_ValorEntrada", TypeName = "decimal(15, 2)")]
    public decimal? CxoValorEntrada { get; set; }

    [Column("CXO_SaldoFinal", TypeName = "decimal(15, 2)")]
    public decimal? CxoSaldoFinal { get; set; }

    [Column("CXO_DataEntradaOperador", TypeName = "smalldatetime")]
    public DateTime? CxoDataEntradaOperador { get; set; }

    [Column("CXO_DataSaidaOperador", TypeName = "smalldatetime")]
    public DateTime? CxoDataSaidaOperador { get; set; }

    [Column("CXO_NumeroCaixa")]
    public short? CxoNumeroCaixa { get; set; }

    [Column("CXC_Codigo")]
    public int? CxcCodigo { get; set; }

    [Column("OPE_Codigo")]
    public short? OpeCodigo { get; set; }

    [Column("EMP_Codigo")]
    public short? EmpCodigo { get; set; }

    [Column("CXA_Codigo")]
    public short? CxaCodigo { get; set; }

    [InverseProperty("CxoCodigoNavigation")]
    public virtual ICollection<CaixaLancamento> CaixaLancamentos { get; set; } = new List<CaixaLancamento>();
}
