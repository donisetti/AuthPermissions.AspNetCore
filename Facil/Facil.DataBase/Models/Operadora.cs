using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("OPERADORA")]
public partial class Operadora
{
    [Column("OPE_Descricao")]
    [StringLength(40)]
    [Unicode(false)]
    public string OpeDescricao { get; set; } = null!;

    [Key]
    [Column("OPE_Codigo")]
    public short OpeCodigo { get; set; }
}
