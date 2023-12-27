using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("TRIBUTACAO")]
public partial class Tributacao
{
    [Key]
    [Column("TRB_Codigo")]
    public short TrbCodigo { get; set; }

    [Column("TRB_Descricao")]
    [StringLength(30)]
    [Unicode(false)]
    public string TrbDescricao { get; set; } = null!;

    [Column("TRB_AliquotaSped", TypeName = "decimal(6, 2)")]
    public decimal? TrbAliquotaSped { get; set; }

    [Column("trb_pct_aliquota")]
    [StringLength(6)]
    [Unicode(false)]
    public string? TrbPctAliquota { get; set; }

    [InverseProperty("TrbCodigoNavigation")]
    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
