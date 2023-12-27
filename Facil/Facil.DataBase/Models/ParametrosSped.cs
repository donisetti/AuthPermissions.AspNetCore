using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Keyless]
[Table("PARAMETROS_SPED")]
public partial class ParametrosSped
{
    [Column("EMP_Codigo")]
    public short? EmpCodigo { get; set; }

    [Column("SPED_Versao")]
    [StringLength(3)]
    [Unicode(false)]
    public string? SpedVersao { get; set; }

    [Column("SPED_DirArquivo")]
    [StringLength(250)]
    [Unicode(false)]
    public string? SpedDirArquivo { get; set; }

    [Column("SPED_EmiteSped")]
    public bool? SpedEmiteSped { get; set; }

    [ForeignKey("EmpCodigo")]
    public virtual EmpresasGrupo? EmpCodigoNavigation { get; set; }
}
