using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("ENTRADA_ITEM")]
public partial class EntradaItem
{
    [Key]
    [Column("ETI_Codigo")]
    public int EtiCodigo { get; set; }

    [Column("ETI_Quantidade", TypeName = "decimal(10, 3)")]
    public decimal EtiQuantidade { get; set; }

    [Column("ENT_Codigo")]
    public int? EntCodigo { get; set; }

    [Column("PRO_Codigo")]
    public int? ProCodigo { get; set; }

    [Column("ETI_ValorCusto", TypeName = "decimal(15, 2)")]
    public decimal? EtiValorCusto { get; set; }

    [Column("ETI_DataEntrada", TypeName = "smalldatetime")]
    public DateTime? EtiDataEntrada { get; set; }

    [Column("LOT_DataVencimento", TypeName = "smalldatetime")]
    public DateTime? LotDataVencimento { get; set; }

    [Column("ETI_IpiEntrada", TypeName = "decimal(5, 2)")]
    public decimal? EtiIpiEntrada { get; set; }

    [Column("ETI_ValorFreteUnitario", TypeName = "decimal(15, 3)")]
    public decimal? EtiValorFreteUnitario { get; set; }

    [Column("STICMS_Codigo")]
    [StringLength(4)]
    [Unicode(false)]
    public string? SticmsCodigo { get; set; }

    [Column("CFOP_Codigo")]
    [StringLength(5)]
    [Unicode(false)]
    public string? CfopCodigo { get; set; }

    [Column("ETI_AliqICMS", TypeName = "decimal(15, 2)")]
    public decimal? EtiAliqIcms { get; set; }

    [Column("ETI_BaseCalcICMS", TypeName = "decimal(15, 2)")]
    public decimal? EtiBaseCalcIcms { get; set; }

    [Column("ETI_ValorICMS", TypeName = "decimal(15, 2)")]
    public decimal? EtiValorIcms { get; set; }

    [Column("UNI_Codigo")]
    public short? UniCodigo { get; set; }

    [Column("ETI_AliqICMSST", TypeName = "decimal(15, 2)")]
    public decimal? EtiAliqIcmsst { get; set; }

    [Column("STIPI_Codigo")]
    [StringLength(4)]
    [Unicode(false)]
    public string? StipiCodigo { get; set; }

    [Column("ETI_BaseCalcIPI", TypeName = "decimal(15, 2)")]
    public decimal? EtiBaseCalcIpi { get; set; }

    [Column("ETI_AliqIPI", TypeName = "decimal(15, 2)")]
    public decimal? EtiAliqIpi { get; set; }

    [Column("ETI_ValorIPI", TypeName = "decimal(15, 2)")]
    public decimal? EtiValorIpi { get; set; }

    [Column("STPIS_Codigo")]
    [StringLength(4)]
    [Unicode(false)]
    public string? StpisCodigo { get; set; }

    [Column("ETI_BaseCalcPIS", TypeName = "decimal(15, 2)")]
    public decimal? EtiBaseCalcPis { get; set; }

    [Column("ETI_ValorPIS", TypeName = "decimal(15, 2)")]
    public decimal? EtiValorPis { get; set; }

    [Column("ETI_AliqPIS", TypeName = "decimal(15, 2)")]
    public decimal? EtiAliqPis { get; set; }

    [Column("STCOFINS_Codigo")]
    [StringLength(4)]
    [Unicode(false)]
    public string? StcofinsCodigo { get; set; }

    [Column("ETI_BaseCalcCOFINS", TypeName = "decimal(15, 2)")]
    public decimal? EtiBaseCalcCofins { get; set; }

    [Column("ETI_AliqCOFINS", TypeName = "decimal(15, 2)")]
    public decimal? EtiAliqCofins { get; set; }

    [Column("ETI_ValorCOFINS", TypeName = "decimal(15, 2)")]
    public decimal? EtiValorCofins { get; set; }

    [Column("ETI_BaseCalcICMSST", TypeName = "decimal(15, 2)")]
    public decimal? EtiBaseCalcIcmsst { get; set; }

    [Column("ETI_ValorICMSST", TypeName = "decimal(15, 2)")]
    public decimal? EtiValorIcmsst { get; set; }

    [Column("ETI_ValorDesconto", TypeName = "decimal(15, 2)")]
    public decimal? EtiValorDesconto { get; set; }

    [Column("ETI_ValorTotal", TypeName = "decimal(15, 2)")]
    public decimal? EtiValorTotal { get; set; }

    [Column("ETI_ValorOutrasDespesas", TypeName = "decimal(15, 2)")]
    public decimal? EtiValorOutrasDespesas { get; set; }

    [Column("ETI_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EtiDescricao { get; set; }

    [Column("ETI_DesUnidadeMedida")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EtiDesUnidadeMedida { get; set; }

    [Column("ETI_CodUnidadeMedida")]
    public short? EtiCodUnidadeMedida { get; set; }

    [ForeignKey("EntCodigo")]
    [InverseProperty("EntradaItems")]
    public virtual Entradum? EntCodigoNavigation { get; set; }
}
