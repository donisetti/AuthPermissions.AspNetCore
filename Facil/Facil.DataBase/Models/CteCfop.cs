using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("CTe_CFOP")]
public partial class CteCfop
{
    [Key]
    [Column("CFOP_Codigo")]
    [StringLength(4)]
    [Unicode(false)]
    public string CfopCodigo { get; set; } = null!;

    [Column("CFOP_Descricao")]
    [StringLength(255)]
    [Unicode(false)]
    public string CfopDescricao { get; set; } = null!;
}
