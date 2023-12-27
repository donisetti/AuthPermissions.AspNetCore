using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("TRANSFERENCIA_INSUMOS")]
public partial class TransferenciaInsumo
{
    [Key]
    [Column("TIN_Codigo")]
    public int TinCodigo { get; set; }

    [Column("TIN_DataNF", TypeName = "smalldatetime")]
    public DateTime TinDataNf { get; set; }

    [Column("TIN_NumeroNF")]
    [StringLength(50)]
    [Unicode(false)]
    public string TinNumeroNf { get; set; } = null!;

    [Column("FOR_CodigoOrigem")]
    public int ForCodigoOrigem { get; set; }

    [Column("FOR_CodigoDestino")]
    public int ForCodigoDestino { get; set; }

    [Column("TIN_Quantidade", TypeName = "decimal(5, 1)")]
    public decimal TinQuantidade { get; set; }

    [Column("TIN_DataTransferencia", TypeName = "smalldatetime")]
    public DateTime TinDataTransferencia { get; set; }

    [Column("TIN_NumeroLote")]
    [StringLength(30)]
    [Unicode(false)]
    public string TinNumeroLote { get; set; } = null!;

    [Column("SUB_Codigo")]
    public short SubCodigo { get; set; }

    [Column("TNF_Codigo")]
    public short TnfCodigo { get; set; }

    [Column("TUI_Codigo")]
    public short TuiCodigo { get; set; }

    [Column("FOR_CodigoInsumo")]
    public int ForCodigoInsumo { get; set; }

    [Column("TIN_DataEnvio", TypeName = "smalldatetime")]
    public DateTime TinDataEnvio { get; set; }

    [Column("TIN_DataMovimentacao", TypeName = "smalldatetime")]
    public DateTime TinDataMovimentacao { get; set; }

    [ForeignKey("ForCodigoInsumo")]
    [InverseProperty("TransferenciaInsumos")]
    public virtual Juridica ForCodigoInsumoNavigation { get; set; } = null!;

    [ForeignKey("SubCodigo")]
    [InverseProperty("TransferenciaInsumos")]
    public virtual Substancium SubCodigoNavigation { get; set; } = null!;

    [ForeignKey("TnfCodigo")]
    [InverseProperty("TransferenciaInsumos")]
    public virtual TipoNotafiscal TnfCodigoNavigation { get; set; } = null!;

    [ForeignKey("TuiCodigo")]
    [InverseProperty("TransferenciaInsumos")]
    public virtual TipoUnidadeInsumo TuiCodigoNavigation { get; set; } = null!;
}
