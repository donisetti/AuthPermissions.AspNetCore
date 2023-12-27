using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Keyless]
[Table("VENDA_VDA_CUPOM_NFE")]
public partial class VendaVdaCupomNfe
{
    [Column("VDA_Codigo")]
    public long? VdaCodigo { get; set; }

    [Column("VDA_CupomNfe")]
    [StringLength(8)]
    [Unicode(false)]
    public string? VdaCupomNfe { get; set; }

    [Column("EMP_Codigo")]
    public short? EmpCodigo { get; set; }
}
