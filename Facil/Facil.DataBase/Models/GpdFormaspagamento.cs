using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("GPD_FORMASPAGAMENTO")]
public partial class GpdFormaspagamento
{
    [Key]
    [Column("GPDFPG_Codigo")]
    public int GpdfpgCodigo { get; set; }

    [Column("GPD_CODIGO")]
    public int GpdCodigo { get; set; }

    [Column("FPG_Codigo")]
    public int FpgCodigo { get; set; }
}
