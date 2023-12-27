using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Keyless]
[Table("CARTAO")]
public partial class Cartao
{
    [Column("CAR_Descricao")]
    [StringLength(40)]
    [Unicode(false)]
    public string CarDescricao { get; set; } = null!;

    [Column("CAR_Codigo")]
    public short CarCodigo { get; set; }
}
