using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[PrimaryKey("OpeCodigo", "CarCodigo")]
[Table("OPERADORA_CARTAO")]
public partial class OperadoraCartao
{
    [Column("OPC_NumDiasRecCredito")]
    public short OpcNumDiasRecCredito { get; set; }

    [Column("OPC_PercentCredito", TypeName = "decimal(5, 2)")]
    public decimal OpcPercentCredito { get; set; }

    [Column("OPC_NumDiasRecDebito")]
    public short OpcNumDiasRecDebito { get; set; }

    [Column("OPC_PercentDebito", TypeName = "decimal(5, 2)")]
    public decimal OpcPercentDebito { get; set; }

    [Key]
    [Column("CAR_Codigo")]
    public short CarCodigo { get; set; }

    [Key]
    [Column("OPE_Codigo")]
    public short OpeCodigo { get; set; }
}
