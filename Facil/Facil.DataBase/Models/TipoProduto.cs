using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("TIPO_PRODUTO")]
public partial class TipoProduto
{
    [Key]
    [Column("TIP_Codigo")]
    public short TipCodigo { get; set; }

    [Column("TIP_Descricao")]
    [StringLength(20)]
    [Unicode(false)]
    public string? TipDescricao { get; set; }

    [InverseProperty("TipCodigoNavigation")]
    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
