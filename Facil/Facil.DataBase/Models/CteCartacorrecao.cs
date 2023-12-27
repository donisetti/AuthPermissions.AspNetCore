using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Keyless]
[Table("CTe_CARTACORRECAO")]
public partial class CteCartacorrecao
{
    [Column("CCTE_Codigo")]
    public int? CcteCodigo { get; set; }

    [Column("CCTE_DataHora", TypeName = "smalldatetime")]
    public DateTime? CcteDataHora { get; set; }

    [Column("CCTE_NumeroSequencia")]
    public int? CcteNumeroSequencia { get; set; }

    [Column("CCTE_Correcao")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? CcteCorrecao { get; set; }

    [Column("CCTE_nCt")]
    public int? CcteNCt { get; set; }

    [Column("CCTE_XmlRetorno", TypeName = "text")]
    public string? CcteXmlRetorno { get; set; }
}
