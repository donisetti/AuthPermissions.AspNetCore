using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("CHEQUE_TELEFONE_SACADO")]
public partial class ChequeTelefoneSacado
{
    [Key]
    [Column("TES_Codigo")]
    public short TesCodigo { get; set; }

    [Column("TES_Area")]
    [StringLength(2)]
    [Unicode(false)]
    public string? TesArea { get; set; }

    [Column("TES_Telefone")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TesTelefone { get; set; }

    [Column("SAC_Codigo")]
    public int? SacCodigo { get; set; }

    [ForeignKey("SacCodigo")]
    [InverseProperty("ChequeTelefoneSacados")]
    public virtual ChequeSacado? SacCodigoNavigation { get; set; }
}
