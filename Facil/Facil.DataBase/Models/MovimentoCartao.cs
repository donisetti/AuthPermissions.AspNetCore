using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("MOVIMENTO_CARTAO")]
public partial class MovimentoCartao
{
    [Column("CRE_ValorCredito", TypeName = "decimal(15, 2)")]
    public decimal CreValorCredito { get; set; }

    [Column("CRE_ValorDebito", TypeName = "decimal(15, 2)")]
    public decimal CreValorDebito { get; set; }

    [Column("CAR_Codigo")]
    public short CarCodigo { get; set; }

    [Column("OPE_Codigo")]
    public short OpeCodigo { get; set; }

    [Column("CRE_Data", TypeName = "datetime")]
    public DateTime CreData { get; set; }

    [Key]
    [Column("CRE_Codigo")]
    public short CreCodigo { get; set; }
}
