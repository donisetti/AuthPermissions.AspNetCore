using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[PrimaryKey("EmiCodigo", "ModCodigo")]
[Table("CTE_EMITENTE_MODAL")]
public partial class CteEmitenteModal
{
    [Key]
    [Column("EMI_Codigo")]
    public short EmiCodigo { get; set; }

    [Key]
    [Column("MOD_Codigo")]
    public short ModCodigo { get; set; }

    [ForeignKey("EmiCodigo")]
    [InverseProperty("CteEmitenteModals")]
    public virtual Emitente EmiCodigoNavigation { get; set; } = null!;
}
