using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("FARMACOLOGIA")]
public partial class Farmacologium
{
    [Key]
    [Column("FIA_Codigo")]
    public short FiaCodigo { get; set; }

    [Column("FIA_Descricao")]
    [StringLength(120)]
    [Unicode(false)]
    public string FiaDescricao { get; set; } = null!;
}
