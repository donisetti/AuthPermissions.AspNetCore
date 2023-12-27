using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("CLASSE_TERAPEUTICA")]
public partial class ClasseTerapeutica
{
    [Key]
    [Column("CLAT_Codigo")]
    public short ClatCodigo { get; set; }

    [Column("CLAT_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ClatDescricao { get; set; }

    [InverseProperty("ClatCodigoNavigation")]
    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
