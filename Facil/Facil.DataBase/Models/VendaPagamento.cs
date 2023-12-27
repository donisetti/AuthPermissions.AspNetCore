using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("VENDA_PAGAMENTO")]
public partial class VendaPagamento
{
    [Key]
    [Column("VPG_Codigo")]
    public long VpgCodigo { get; set; }

    [Column("VPG_Valor", TypeName = "decimal(15, 2)")]
    public decimal VpgValor { get; set; }

    [Column("VPG_DataVencimento", TypeName = "smalldatetime")]
    public DateTime? VpgDataVencimento { get; set; }

    [Column("FPG_Codigo")]
    public short? FpgCodigo { get; set; }

    [Column("VDA_Codigo")]
    public long? VdaCodigo { get; set; }

    [Column("VPG_ValorRecebido", TypeName = "decimal(15, 2)")]
    public decimal? VpgValorRecebido { get; set; }

    [ForeignKey("VdaCodigo")]
    [InverseProperty("VendaPagamentos")]
    public virtual Vendum? VdaCodigoNavigation { get; set; }
}
