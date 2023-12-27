using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[PrimaryKey("PaiCodigo", "PaiIbge")]
[Table("PAIS")]
public partial class Pai
{
    [Key]
    [Column("PAI_Codigo")]
    public short PaiCodigo { get; set; }

    [Column("PAI_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PaiDescricao { get; set; }

    [Key]
    [Column("PAI_IBGE")]
    public int PaiIbge { get; set; }
}
