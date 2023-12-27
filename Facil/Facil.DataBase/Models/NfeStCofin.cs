using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("NFe_ST_COFINS")]
public partial class NfeStCofin
{
    [Key]
    [Column("STCOF_Codigo")]
    [StringLength(3)]
    [Unicode(false)]
    public string StcofCodigo { get; set; } = null!;

    [Column("STCOF_Descricao")]
    [StringLength(150)]
    [Unicode(false)]
    public string StcofDescricao { get; set; } = null!;
}
