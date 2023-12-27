using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("NFCe_CONTINGENCIA")]
public partial class NfceContingencium
{
    [Key]
    [Column("CON_Codigo")]
    public long ConCodigo { get; set; }

    [Column("NFCE_Codigo")]
    public long? NfceCodigo { get; set; }

    [Column("CON_Xml", TypeName = "text")]
    public string? ConXml { get; set; }

    [ForeignKey("NfceCodigo")]
    [InverseProperty("NfceContingencia")]
    public virtual NfceInfnotafiscal? NfceCodigoNavigation { get; set; }
}
