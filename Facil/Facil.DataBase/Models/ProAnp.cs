using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Keyless]
[Table("PRO_ANP")]
public partial class ProAnp
{
    [Column("ANP_CODIGO")]
    public int AnpCodigo { get; set; }

    [Column("ANP_DESCRICAO")]
    [StringLength(90)]
    [Unicode(false)]
    public string? AnpDescricao { get; set; }
}
