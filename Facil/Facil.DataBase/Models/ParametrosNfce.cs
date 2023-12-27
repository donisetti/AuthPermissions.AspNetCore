using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PARAMETROS_NFCE")]
public partial class ParametrosNfce
{
    [Key]
    [Column("EMP_Codigo")]
    public short EmpCodigo { get; set; }

    [Column("NFCE_Codigo")]
    public int? NfceCodigo { get; set; }

    [Column("NFCE_DirXmlEnvio")]
    [StringLength(250)]
    [Unicode(false)]
    public string? NfceDirXmlEnvio { get; set; }

    [Column("NFCE_DirXmlRecebido")]
    [StringLength(250)]
    [Unicode(false)]
    public string? NfceDirXmlRecebido { get; set; }

    [Column("NFCE_DirBackup")]
    [StringLength(250)]
    [Unicode(false)]
    public string? NfceDirBackup { get; set; }

    [Column("NFCE_DirPdfDanfe")]
    [StringLength(250)]
    [Unicode(false)]
    public string? NfceDirPdfDanfe { get; set; }

    [Column("NFCE_DirXmlContingencia")]
    [StringLength(250)]
    [Unicode(false)]
    public string? NfceDirXmlContingencia { get; set; }

    [ForeignKey("EmpCodigo")]
    [InverseProperty("ParametrosNfce")]
    public virtual EmpresasGrupo EmpCodigoNavigation { get; set; } = null!;
}
