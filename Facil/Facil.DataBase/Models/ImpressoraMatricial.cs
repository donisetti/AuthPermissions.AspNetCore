using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("IMPRESSORA_MATRICIAL")]
public partial class ImpressoraMatricial
{
    [Key]
    [Column("IMP_Codigo")]
    public short ImpCodigo { get; set; }

    [Column("IMP_Descricao")]
    [StringLength(30)]
    [Unicode(false)]
    public string ImpDescricao { get; set; } = null!;
}
