using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PARAMETROS_NFSE")]
public partial class ParametrosNfse
{
    [Column("EMP_Codigo")]
    public short? EmpCodigo { get; set; }

    [Key]
    [Column("NFSE_Codigo")]
    public int NfseCodigo { get; set; }

    [Column("NFSE_DirXmlRecebido")]
    [StringLength(250)]
    [Unicode(false)]
    public string? NfseDirXmlRecebido { get; set; }

    [Column("NFSE_DirPdfDanfe")]
    [StringLength(250)]
    [Unicode(false)]
    public string? NfseDirPdfDanfe { get; set; }

    [Column("NFSE_DirBackup")]
    [StringLength(250)]
    [Unicode(false)]
    public string? NfseDirBackup { get; set; }

    [ForeignKey("EmpCodigo")]
    [InverseProperty("ParametrosNfses")]
    public virtual EmpresasGrupo? EmpCodigoNavigation { get; set; }
}
