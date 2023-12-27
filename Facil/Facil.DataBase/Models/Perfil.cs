using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PERFIL")]
public partial class Perfil
{
    [Key]
    [Column("PER_Codigo")]
    public int PerCodigo { get; set; }

    [Column("PER_Descricao")]
    [StringLength(40)]
    [Unicode(false)]
    public string? PerDescricao { get; set; }

    [Column("PER_Liberado")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PerLiberado { get; set; }
}
