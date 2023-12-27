using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("NFe_ST_PIS")]
public partial class NfeStPi
{
    [Key]
    [Column("STPIS_Codigo")]
    [StringLength(3)]
    [Unicode(false)]
    public string StpisCodigo { get; set; } = null!;

    [Column("STPIS_Descricao")]
    [StringLength(150)]
    [Unicode(false)]
    public string StpisDescricao { get; set; } = null!;
}
