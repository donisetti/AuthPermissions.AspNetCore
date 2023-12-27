using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("DISTRIBUIDORA")]
public partial class Distribuidora
{
    [Key]
    [Column("DIS_Codigo")]
    public short DisCodigo { get; set; }

    [Column("DIS_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string DisDescricao { get; set; } = null!;

    [InverseProperty("DisCodigoNavigation")]
    public virtual ICollection<FabricanteDistribuidora> FabricanteDistribuidoras { get; set; } = new List<FabricanteDistribuidora>();
}
