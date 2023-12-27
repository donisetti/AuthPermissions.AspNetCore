using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("REGISTRO_ECF")]
public partial class RegistroEcf
{
    [Key]
    [Column("REG_Codigo")]
    public short RegCodigo { get; set; }

    [Column("REG_Serial")]
    [StringLength(20)]
    [Unicode(false)]
    public string RegSerial { get; set; } = null!;

    [Column("IMP_Codigo")]
    public short ImpCodigo { get; set; }

    [Column("IMP_MFAdicional")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ImpMfadicional { get; set; }

    [Column("IMP_TipoECF")]
    [StringLength(7)]
    public string? ImpTipoEcf { get; set; }

    [Column("IMP_ModeloECF")]
    [StringLength(20)]
    public string? ImpModeloEcf { get; set; }

    [Column("IMP_VersaoSB")]
    [StringLength(10)]
    public string? ImpVersaoSb { get; set; }

    [Column("IMP_DataInstallSB", TypeName = "datetime")]
    public DateTime? ImpDataInstallSb { get; set; }

    [Column("IMP_HoraInstallSB", TypeName = "datetime")]
    public DateTime? ImpHoraInstallSb { get; set; }

    [Column("IMP_NumeroECF")]
    public int? ImpNumeroEcf { get; set; }

    [ForeignKey("ImpCodigo")]
    [InverseProperty("RegistroEcfs")]
    public virtual Impressora ImpCodigoNavigation { get; set; } = null!;
}
