using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("NFe_NOTA_CUPOM")]
public partial class NfeNotaCupom
{
    [Key]
    [Column("NFC_Codigo")]
    public long NfcCodigo { get; set; }

    [Column("NFE_Codigo")]
    public int? NfeCodigo { get; set; }

    [Column("VDA_Codigo")]
    public long? VdaCodigo { get; set; }

    [ForeignKey("NfeCodigo")]
    [InverseProperty("NfeNotaCupoms")]
    public virtual NfeInfnotafiscal? NfeCodigoNavigation { get; set; }

    [ForeignKey("VdaCodigo")]
    [InverseProperty("NfeNotaCupoms")]
    public virtual Vendum? VdaCodigoNavigation { get; set; }
}
