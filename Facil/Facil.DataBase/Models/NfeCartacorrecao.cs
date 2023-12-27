using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Keyless]
[Table("NFe_CARTACORRECAO")]
public partial class NfeCartacorrecao
{
    [Column("CCE_Codigo")]
    public int? CceCodigo { get; set; }

    [Column("CCE_DataHora", TypeName = "smalldatetime")]
    public DateTime? CceDataHora { get; set; }

    [Column("CCE_NumeroSequencia")]
    public int? CceNumeroSequencia { get; set; }

    [Column("CCE_Correcao")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? CceCorrecao { get; set; }

    [Column("CCE_nNf")]
    public int? CceNNf { get; set; }

    [Column("CCE_XmlRetorno", TypeName = "text")]
    public string? CceXmlRetorno { get; set; }
}
