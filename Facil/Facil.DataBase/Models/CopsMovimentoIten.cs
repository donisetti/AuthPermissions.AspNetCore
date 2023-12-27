using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("COPS_MOVIMENTO_ITENS")]
public partial class CopsMovimentoIten
{
    [Key]
    [Column("IMO_Codigo")]
    public long ImoCodigo { get; set; }

    [Column("MOV_Codigo")]
    public long MovCodigo { get; set; }

    [Column("IMO_Quantidade", TypeName = "decimal(10, 3)")]
    public decimal? ImoQuantidade { get; set; }

    [Column("PRO_Codigo")]
    public int ProCodigo { get; set; }

    [ForeignKey("MovCodigo")]
    [InverseProperty("CopsMovimentoItens")]
    public virtual CopsMovimento MovCodigoNavigation { get; set; } = null!;
}
