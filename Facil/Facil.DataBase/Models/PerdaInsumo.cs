using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PERDA_INSUMOS")]
public partial class PerdaInsumo
{
    [Key]
    [Column("PIN_Codigo")]
    public int PinCodigo { get; set; }

    [Column("PIN_NumeroLote")]
    [StringLength(30)]
    [Unicode(false)]
    public string PinNumeroLote { get; set; } = null!;

    [Column("PIN_Quantidade", TypeName = "decimal(5, 1)")]
    public decimal PinQuantidade { get; set; }

    [Column("PIN_DataPerda", TypeName = "smalldatetime")]
    public DateTime PinDataPerda { get; set; }

    [Column("FOR_CodigoInsumo")]
    public int ForCodigoInsumo { get; set; }

    [Column("SUB_Codigo")]
    public short SubCodigo { get; set; }

    [Column("TMP_Codigo")]
    public short TmpCodigo { get; set; }

    [Column("TUI_Codigo")]
    public short TuiCodigo { get; set; }

    [Column("PIN_DataEnvio", TypeName = "smalldatetime")]
    public DateTime PinDataEnvio { get; set; }

    [Column("PIN_DataMovimentacao", TypeName = "smalldatetime")]
    public DateTime PinDataMovimentacao { get; set; }

    [ForeignKey("ForCodigoInsumo")]
    [InverseProperty("PerdaInsumos")]
    public virtual Juridica ForCodigoInsumoNavigation { get; set; } = null!;

    [ForeignKey("SubCodigo")]
    [InverseProperty("PerdaInsumos")]
    public virtual Substancium SubCodigoNavigation { get; set; } = null!;

    [ForeignKey("TmpCodigo")]
    [InverseProperty("PerdaInsumos")]
    public virtual TipoMotivoPerdum TmpCodigoNavigation { get; set; } = null!;

    [ForeignKey("TuiCodigo")]
    [InverseProperty("PerdaInsumos")]
    public virtual TipoUnidadeInsumo TuiCodigoNavigation { get; set; } = null!;
}
