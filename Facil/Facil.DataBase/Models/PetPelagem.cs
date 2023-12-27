using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PET_PELAGEM")]
public partial class PetPelagem
{
    [Key]
    [Column("PEL_Codigo")]
    public short PelCodigo { get; set; }

    [Column("PEL_Descricao")]
    [StringLength(30)]
    [Unicode(false)]
    public string? PelDescricao { get; set; }
}
