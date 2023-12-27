using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Keyless]
public partial class Teste
{
    [Column("SER_Codigo")]
    public int SerCodigo { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Pecas { get; set; }

    [Column("servicos", TypeName = "decimal(10, 2)")]
    public decimal? Servicos { get; set; }
}
