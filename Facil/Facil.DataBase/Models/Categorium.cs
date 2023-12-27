using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("CATEGORIA")]
public partial class Categorium
{
    [Key]
    [Column("CAT_Codigo")]
    public short CatCodigo { get; set; }

    [Column("CAT_Descricao")]
    [StringLength(40)]
    [Unicode(false)]
    public string CatDescricao { get; set; } = null!;

    [InverseProperty("CatCodigoNavigation")]
    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
