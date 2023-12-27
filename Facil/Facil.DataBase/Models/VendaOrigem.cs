using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("VENDA_ORIGEM")]
public partial class VendaOrigem
{
    [Key]
    [Column("VOR_Codigo")]
    public short VorCodigo { get; set; }

    [Column("VOR_Descricao")]
    [StringLength(30)]
    [Unicode(false)]
    public string? VorDescricao { get; set; }
}
