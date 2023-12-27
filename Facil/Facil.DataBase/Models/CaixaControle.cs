using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("CAIXA_CONTROLE")]
public partial class CaixaControle
{
    [Key]
    [Column("CXC_Codigo")]
    public int CxcCodigo { get; set; }

    [Column("CXC_ValorEntrada", TypeName = "decimal(15, 2)")]
    public decimal? CxcValorEntrada { get; set; }

    [Column("CXC_SaldoInicial", TypeName = "decimal(15, 2)")]
    public decimal? CxcSaldoInicial { get; set; }

    [Column("CXC_SaldoFinal", TypeName = "decimal(15, 2)")]
    public decimal? CxcSaldoFinal { get; set; }

    [Column("CXC_DataAbertura", TypeName = "datetime")]
    public DateTime? CxcDataAbertura { get; set; }

    [Column("CXC_HoraAbertura", TypeName = "datetime")]
    public DateTime? CxcHoraAbertura { get; set; }

    [Column("CXC_DataFechamento", TypeName = "datetime")]
    public DateTime? CxcDataFechamento { get; set; }

    [Column("CXC_HoraFechamento", TypeName = "datetime")]
    public DateTime? CxcHoraFechamento { get; set; }

    [Column("CXC_SaldoMovimentacao", TypeName = "decimal(15, 2)")]
    public decimal? CxcSaldoMovimentacao { get; set; }

    [Column("CXC_SaldoContasReceber", TypeName = "decimal(15, 2)")]
    public decimal? CxcSaldoContasReceber { get; set; }

    [Column("EMP_Codigo")]
    public short? EmpCodigo { get; set; }
}
