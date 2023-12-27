using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PARAMETROS_NFE")]
public partial class ParametrosNfe
{
    [Key]
    [Column("EMP_Codigo")]
    public short EmpCodigo { get; set; }

    [Column("NFE_Codigo")]
    public int? NfeCodigo { get; set; }

    /// <summary>
    /// Diretório para onde será exportado o xml de envio
    /// </summary>
    [Column("NFE_DirXmlEnvio")]
    [StringLength(250)]
    [Unicode(false)]
    public string? NfeDirXmlEnvio { get; set; }

    /// <summary>
    /// Diretório para onde será exportado o xml recebido após o envio
    /// </summary>
    [Column("NFE_DirXmlRecebido")]
    [StringLength(250)]
    [Unicode(false)]
    public string? NfeDirXmlRecebido { get; set; }

    /// <summary>
    /// Diretório para onde será exportado o pdf da Danfe
    /// </summary>
    [Column("NFE_DirPdfDanfe")]
    [StringLength(250)]
    [Unicode(false)]
    public string? NfeDirPdfDanfe { get; set; }

    /// <summary>
    /// Justificativa padrão de cancelamento 
    /// </summary>
    [Column("NFE_JustCancelamento")]
    [StringLength(255)]
    [Unicode(false)]
    public string? NfeJustCancelamento { get; set; }

    [Column("NFE_DirBackup")]
    [StringLength(250)]
    [Unicode(false)]
    public string? NfeDirBackup { get; set; }

    [Column("NFE_BaixarDfeDist")]
    public bool? NfeBaixarDfeDist { get; set; }

    [Column("NFE_DtPesquisaDFe", TypeName = "smalldatetime")]
    public DateTime? NfeDtPesquisaDfe { get; set; }

    [Column("NFE_IntervaloPesqDFe")]
    public double? NfeIntervaloPesqDfe { get; set; }

    [Column("NFE_LiberaDownloadDFe")]
    public bool? NfeLiberaDownloadDfe { get; set; }

    [Column("NFE_ultNSU")]
    public int? NfeUltNsu { get; set; }
}
