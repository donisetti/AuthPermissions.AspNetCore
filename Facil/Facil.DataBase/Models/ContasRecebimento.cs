using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("CONTAS_RECEBIMENTO")]
public partial class ContasRecebimento
{
    [Key]
    [Column("COR_Codigo")]
    public long CorCodigo { get; set; }

    [Column("COR_DataRecebimento", TypeName = "smalldatetime")]
    public DateTime? CorDataRecebimento { get; set; }

    [Column("COR_ValorRecebido", TypeName = "decimal(10, 2)")]
    public decimal? CorValorRecebido { get; set; }

    [Column("COR_ValorJurosRecebidos", TypeName = "decimal(10, 2)")]
    public decimal? CorValorJurosRecebidos { get; set; }

    [Column("COR_ValorDesconto", TypeName = "decimal(10, 2)")]
    public decimal? CorValorDesconto { get; set; }

    [Column("COR_ValorAbatido", TypeName = "decimal(10, 2)")]
    public decimal? CorValorAbatido { get; set; }

    [Column("COR_JuroAbatido", TypeName = "decimal(10, 2)")]
    public decimal? CorJuroAbatido { get; set; }

    [Column("COR_JuroRestante", TypeName = "decimal(10, 2)")]
    public decimal? CorJuroRestante { get; set; }

    [Column("COR_DataAbatido", TypeName = "smalldatetime")]
    public DateTime? CorDataAbatido { get; set; }

    [Column("COR_DataEstorno", TypeName = "smalldatetime")]
    public DateTime? CorDataEstorno { get; set; }

    /// <summary>
    /// usuario estorno
    /// </summary>
    [Column("USU_Codigo")]
    public int? UsuCodigo { get; set; }

    [Column("CRE_Codigo")]
    public int CreCodigo { get; set; }

    [Column("COR_DataLancamento", TypeName = "datetime")]
    public DateTime? CorDataLancamento { get; set; }

    [Column("PCT_CodigoReduzido")]
    public int? PctCodigoReduzido { get; set; }

    [ForeignKey("CreCodigo")]
    [InverseProperty("ContasRecebimentos")]
    public virtual ContasReceber CreCodigoNavigation { get; set; } = null!;
}
