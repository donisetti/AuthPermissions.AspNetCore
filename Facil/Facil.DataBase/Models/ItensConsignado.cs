using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("ITENS_CONSIGNADO")]
public partial class ItensConsignado
{
    [Key]
    [Column("ICD_Codigo")]
    public int IcdCodigo { get; set; }

    [Column("CDO_Codigo")]
    public long CdoCodigo { get; set; }

    [Column("ICD_Quantidade", TypeName = "decimal(10, 3)")]
    public decimal? IcdQuantidade { get; set; }

    [Column("ICD_QuantidadeEstorno", TypeName = "decimal(10, 3)")]
    public decimal? IcdQuantidadeEstorno { get; set; }

    [Column("ICD_CustoReal", TypeName = "decimal(15, 2)")]
    public decimal? IcdCustoReal { get; set; }

    [Column("ICD_CustoFabrica", TypeName = "decimal(15, 2)")]
    public decimal? IcdCustoFabrica { get; set; }

    [Column("ICD_ValorVendaUnitario", TypeName = "decimal(15, 2)")]
    public decimal? IcdValorVendaUnitario { get; set; }

    [Column("ICD_DataEstorno", TypeName = "smalldatetime")]
    public DateTime? IcdDataEstorno { get; set; }

    [Column("PRO_Codigo")]
    public int? ProCodigo { get; set; }

    [Column("ICD_Descricao")]
    [StringLength(60)]
    [Unicode(false)]
    public string? IcdDescricao { get; set; }

    [Column("ICD_Apresentacao")]
    [StringLength(60)]
    [Unicode(false)]
    public string? IcdApresentacao { get; set; }

    [Column("ICD_DataLancamento", TypeName = "smalldatetime")]
    public DateTime? IcdDataLancamento { get; set; }

    [Column("VDA_Codigo")]
    public long VdaCodigo { get; set; }

    [ForeignKey("ProCodigo")]
    [InverseProperty("ItensConsignados")]
    public virtual Produto? ProCodigoNavigation { get; set; }

    [ForeignKey("VdaCodigo")]
    [InverseProperty("ItensConsignados")]
    public virtual Vendum VdaCodigoNavigation { get; set; } = null!;
}
