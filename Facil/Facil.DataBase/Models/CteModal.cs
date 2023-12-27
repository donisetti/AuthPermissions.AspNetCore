using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("CTE_MODAL")]
public partial class CteModal
{
    [Key]
    [Column("MOD_Codigo")]
    public short ModCodigo { get; set; }

    [Column("EMI_Codigo")]
    public short? EmiCodigo { get; set; }

    [Column("MOD_Renavan")]
    [StringLength(11)]
    [Unicode(false)]
    public string? ModRenavan { get; set; }

    [Column("MOD_Placa")]
    [StringLength(7)]
    [Unicode(false)]
    public string? ModPlaca { get; set; }

    [Column("MOD_UF")]
    [StringLength(2)]
    [Unicode(false)]
    public string? ModUf { get; set; }

    [ForeignKey("EmiCodigo")]
    [InverseProperty("CteModals")]
    public virtual Emitente? EmiCodigoNavigation { get; set; }
}
