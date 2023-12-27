using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("BULARIO")]
public partial class Bulario
{
    [Key]
    [Column("BUL_Codigo")]
    public int BulCodigo { get; set; }

    [Column("BUL_Bula")]
    [StringLength(120)]
    [Unicode(false)]
    public string BulBula { get; set; } = null!;

    [InverseProperty("BulCodigoNavigation")]
    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
