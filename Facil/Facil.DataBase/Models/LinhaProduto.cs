using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("LINHA_PRODUTO")]
public partial class LinhaProduto
{
    [Key]
    [Column("LIN_Codigo")]
    public short LinCodigo { get; set; }

    [Column("LIN_Descricao")]
    [StringLength(30)]
    [Unicode(false)]
    public string LinDescricao { get; set; } = null!;

    [Column("LIN_Pct_Comissao", TypeName = "decimal(5, 2)")]
    public decimal? LinPctComissao { get; set; }

    [InverseProperty("LinCodigoNavigation")]
    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
