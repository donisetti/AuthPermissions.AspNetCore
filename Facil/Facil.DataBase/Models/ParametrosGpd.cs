using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PARAMETROS_GPD")]
public partial class ParametrosGpd
{
    [Key]
    [Column("PGPD_Codigo")]
    public int PgpdCodigo { get; set; }

    [Column("FPG_Codigo")]
    public int FpgCodigo { get; set; }

    [Column("PCONF_Codigo")]
    public int PconfCodigo { get; set; }

    [Column("PGPD_DESCRICAO")]
    [StringLength(30)]
    [Unicode(false)]
    public string PgpdDescricao { get; set; } = null!;

    [Column("PGPD_FpgAtiva")]
    public bool PgpdFpgAtiva { get; set; }
}
