using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("SAIDA_INSUMOS")]
public partial class SaidaInsumo
{
    [Key]
    [Column("SIN_Codigo")]
    public int SinCodigo { get; set; }

    [Column("SIN_DataVenda", TypeName = "smalldatetime")]
    public DateTime SinDataVenda { get; set; }

    [Column("SIN_NumeroReceita")]
    [StringLength(20)]
    [Unicode(false)]
    public string SinNumeroReceita { get; set; } = null!;

    [Column("SIN_DataReceita", TypeName = "smalldatetime")]
    public DateTime SinDataReceita { get; set; }

    [Column("SIN_NumeroLote")]
    [StringLength(30)]
    [Unicode(false)]
    public string SinNumeroLote { get; set; } = null!;

    [Column("SIN_Qtde_UnidadeInsumo", TypeName = "decimal(5, 1)")]
    public decimal SinQtdeUnidadeInsumo { get; set; }

    [Column("SIN_Qtde_UnidadeFarmacotecnica", TypeName = "decimal(5, 1)")]
    public decimal SinQtdeUnidadeFarmacotecnica { get; set; }

    [Column("SUB_Codigo")]
    public short SubCodigo { get; set; }

    [Column("TUM_Codigo")]
    public short TumCodigo { get; set; }

    [Column("TDO_Codigo")]
    public short TdoCodigo { get; set; }

    [Column("MED_Codigo")]
    public int MedCodigo { get; set; }

    [Column("TIO_Codigo")]
    public short TioCodigo { get; set; }

    [Column("CLI_Codigo")]
    public int CliCodigo { get; set; }

    [Column("FOR_Codigo")]
    public int ForCodigo { get; set; }

    [Column("TUI_Codigo")]
    public short TuiCodigo { get; set; }

    [Column("TUF_Codigo")]
    public short TufCodigo { get; set; }

    [Column("SIN_DataEnvio", TypeName = "smalldatetime")]
    public DateTime SinDataEnvio { get; set; }

    [Column("SIN_DataMovimentacao", TypeName = "smalldatetime")]
    public DateTime SinDataMovimentacao { get; set; }

    [ForeignKey("CliCodigo")]
    [InverseProperty("SaidaInsumos")]
    public virtual Fisica CliCodigoNavigation { get; set; } = null!;

    [ForeignKey("ForCodigo")]
    [InverseProperty("SaidaInsumos")]
    public virtual Juridica ForCodigoNavigation { get; set; } = null!;

    [ForeignKey("MedCodigo")]
    [InverseProperty("SaidaInsumos")]
    public virtual Medico MedCodigoNavigation { get; set; } = null!;

    [ForeignKey("SubCodigo")]
    [InverseProperty("SaidaInsumos")]
    public virtual Substancium SubCodigoNavigation { get; set; } = null!;

    [ForeignKey("TdoCodigo")]
    [InverseProperty("SaidaInsumos")]
    public virtual TipoDocumento TdoCodigoNavigation { get; set; } = null!;

    [ForeignKey("TioCodigo")]
    [InverseProperty("SaidaInsumos")]
    public virtual TipoReceituario TioCodigoNavigation { get; set; } = null!;

    [ForeignKey("TufCodigo")]
    [InverseProperty("SaidaInsumos")]
    public virtual TipoUnidadeFarmacotecnica TufCodigoNavigation { get; set; } = null!;

    [ForeignKey("TuiCodigo")]
    [InverseProperty("SaidaInsumos")]
    public virtual TipoUnidadeInsumo TuiCodigoNavigation { get; set; } = null!;

    [ForeignKey("TumCodigo")]
    [InverseProperty("SaidaInsumos")]
    public virtual TipoUsoMedicamento TumCodigoNavigation { get; set; } = null!;
}
