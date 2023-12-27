using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("SER_STATUS")]
public partial class SerStatus
{
    [Key]
    [Column("STA_Codigo")]
    public short StaCodigo { get; set; }

    [Column("STA_Descricao")]
    [StringLength(30)]
    [Unicode(false)]
    public string? StaDescricao { get; set; }

    [Column("STA_Esconder")]
    public bool? StaEsconder { get; set; }

    [InverseProperty("StaCodigoNavigation")]
    public virtual ICollection<SerServico> SerServicos { get; set; } = new List<SerServico>();
}
