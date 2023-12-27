using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[PrimaryKey("SubCodigo", "ProCodigo")]
[Table("SUBSTANCIA_PRODUTO")]
public partial class SubstanciaProduto
{
    [Key]
    [Column("SUB_Codigo")]
    public short SubCodigo { get; set; }

    [Key]
    [Column("PRO_Codigo")]
    public int ProCodigo { get; set; }

    [ForeignKey("ProCodigo")]
    [InverseProperty("SubstanciaProdutos")]
    public virtual Produto ProCodigoNavigation { get; set; } = null!;
}
