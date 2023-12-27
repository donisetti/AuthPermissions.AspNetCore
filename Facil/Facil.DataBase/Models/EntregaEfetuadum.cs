using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[PrimaryKey("IvdCodigo", "EfeDataEntrega")]
[Table("ENTREGA_EFETUADA")]
public partial class EntregaEfetuadum
{
    [Key]
    [Column("IVD_Codigo")]
    public long IvdCodigo { get; set; }

    [Key]
    [Column("EFE_DataEntrega", TypeName = "smalldatetime")]
    public DateTime EfeDataEntrega { get; set; }

    [Column("PES_Codigo")]
    public int PesCodigo { get; set; }

    [Column("EFE_QuantidadeEntregue", TypeName = "decimal(10, 3)")]
    public decimal EfeQuantidadeEntregue { get; set; }

    [ForeignKey("PesCodigo")]
    [InverseProperty("EntregaEfetuada")]
    public virtual Pessoa PesCodigoNavigation { get; set; } = null!;
}
