using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Keyless]
[Table("PRODUTO_NF")]
public partial class ProdutoNf
{
    [Column("PRN_Codigo")]
    public long? PrnCodigo { get; set; }

    [Column("PRN_Descricao")]
    [StringLength(250)]
    [Unicode(false)]
    public string? PrnDescricao { get; set; }

    [Column("PRO_Codigo")]
    public int? ProCodigo { get; set; }

    [ForeignKey("ProCodigo")]
    public virtual Produto? ProCodigoNavigation { get; set; }
}
