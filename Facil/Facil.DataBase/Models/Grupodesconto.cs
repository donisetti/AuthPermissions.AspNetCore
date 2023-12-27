using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("GRUPODESCONTO")]
public partial class Grupodesconto
{
    [Key]
    [Column("GPD_Codigo")]
    public int GpdCodigo { get; set; }

    [Column("GPD_DESCRICAO")]
    [StringLength(150)]
    [Unicode(false)]
    public string? GpdDescricao { get; set; }

    [Column("GPD_DataInicio", TypeName = "smalldatetime")]
    public DateTime? GpdDataInicio { get; set; }

    [Column("GPD_DataFim", TypeName = "smalldatetime")]
    public DateTime? GpdDataFim { get; set; }

    [Column("GPD_CliEspecial")]
    public bool? GpdCliEspecial { get; set; }
}
