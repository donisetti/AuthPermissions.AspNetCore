using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("ENTRADA_INSUMOS")]
public partial class EntradaInsumo
{
    [Key]
    [Column("EIS_Codigo")]
    public int EisCodigo { get; set; }

    [Column("EIS_NumeroNF")]
    [StringLength(20)]
    [Unicode(false)]
    public string EisNumeroNf { get; set; } = null!;

    [Column("EIS_DataNF", TypeName = "smalldatetime")]
    public DateTime EisDataNf { get; set; }

    [Column("EIS_NumeroLote")]
    [StringLength(30)]
    [Unicode(false)]
    public string EisNumeroLote { get; set; } = null!;

    [Column("EIS_Quantidade", TypeName = "decimal(5, 1)")]
    public decimal EisQuantidade { get; set; }

    [Column("EIS_DataRecebimento", TypeName = "smalldatetime")]
    public DateTime EisDataRecebimento { get; set; }

    [Column("FOR_CodigoOrigem")]
    public int ForCodigoOrigem { get; set; }

    [Column("FOR_CodigoDestino")]
    public int ForCodigoDestino { get; set; }

    [Column("FOR_CodigoInsumo")]
    public int ForCodigoInsumo { get; set; }

    [Column("SUB_Codigo")]
    public short SubCodigo { get; set; }

    [Column("TNF_Codigo")]
    public short TnfCodigo { get; set; }

    [Column("TUI_Codigo")]
    public short TuiCodigo { get; set; }

    [Column("EIS_DataEnvio", TypeName = "smalldatetime")]
    public DateTime EisDataEnvio { get; set; }

    [Column("EIS_DataMovimentacao", TypeName = "smalldatetime")]
    public DateTime EisDataMovimentacao { get; set; }

    [ForeignKey("SubCodigo")]
    [InverseProperty("EntradaInsumos")]
    public virtual Substancium SubCodigoNavigation { get; set; } = null!;

    [ForeignKey("TnfCodigo")]
    [InverseProperty("EntradaInsumos")]
    public virtual TipoNotafiscal TnfCodigoNavigation { get; set; } = null!;

    [ForeignKey("TuiCodigo")]
    [InverseProperty("EntradaInsumos")]
    public virtual TipoUnidadeInsumo TuiCodigoNavigation { get; set; } = null!;
}
