using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("FABRICANTE_DISTRIBUIDORA")]
public partial class FabricanteDistribuidora
{
    [Key]
    [Column("ID_Codigo")]
    public int IdCodigo { get; set; }

    [Column("FAB_Codigo")]
    public short FabCodigo { get; set; }

    [Column("DIS_Codigo")]
    public short DisCodigo { get; set; }

    [Column("PCT_Desconto", TypeName = "decimal(5, 2)")]
    public decimal PctDesconto { get; set; }

    [ForeignKey("DisCodigo")]
    [InverseProperty("FabricanteDistribuidoras")]
    public virtual Distribuidora DisCodigoNavigation { get; set; } = null!;

    [ForeignKey("FabCodigo")]
    [InverseProperty("FabricanteDistribuidoras")]
    public virtual Fabricante FabCodigoNavigation { get; set; } = null!;
}
