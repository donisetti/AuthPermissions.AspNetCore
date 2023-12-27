using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PERIODICIDADE")]
public partial class Periodicidade
{
    [Key]
    [Column("PDE_Codigo")]
    public short PdeCodigo { get; set; }

    [Column("PDE_Descricao")]
    [StringLength(30)]
    [Unicode(false)]
    public string? PdeDescricao { get; set; }
}
