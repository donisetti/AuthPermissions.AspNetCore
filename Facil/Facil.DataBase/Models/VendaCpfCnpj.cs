using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Keyless]
[Table("VENDA_CPF_CNPJ")]
public partial class VendaCpfCnpj
{
    [Column("VDA_Codigo")]
    public long VdaCodigo { get; set; }

    [Column("VDA_CpfCnpj")]
    [StringLength(18)]
    [Unicode(false)]
    public string VdaCpfCnpj { get; set; } = null!;

    [Column("VDA_MsgComplementarNfce")]
    [StringLength(250)]
    [Unicode(false)]
    public string? VdaMsgComplementarNfce { get; set; }
}
