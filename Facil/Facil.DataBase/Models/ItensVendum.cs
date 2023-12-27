using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("ITENS_VENDA")]
[Index("VdaCodigo", Name = "index_VDA_Codigo")]
public partial class ItensVendum
{
    [Key]
    [Column("IVD_Codigo")]
    public int IvdCodigo { get; set; }

    [Column("VDA_Codigo")]
    public long VdaCodigo { get; set; }

    [Column("IVD_Quantidade", TypeName = "decimal(10, 3)")]
    public decimal? IvdQuantidade { get; set; }

    [Column("IVD_CustoReal", TypeName = "decimal(15, 2)")]
    public decimal? IvdCustoReal { get; set; }

    [Column("IVD_CustoFabrica", TypeName = "decimal(15, 2)")]
    public decimal? IvdCustoFabrica { get; set; }

    [Column("IVD_ValorVendaUnitario", TypeName = "decimal(15, 2)")]
    public decimal? IvdValorVendaUnitario { get; set; }

    [Column("IVD_ValorDescontoProduto", TypeName = "decimal(15, 2)")]
    public decimal? IvdValorDescontoProduto { get; set; }

    [Column("IVD_ValorDescontoItemDevolucao", TypeName = "decimal(15, 3)")]
    public decimal? IvdValorDescontoItemDevolucao { get; set; }

    [Column("IVD_ValorVendaFinal", TypeName = "decimal(15, 2)")]
    public decimal? IvdValorVendaFinal { get; set; }

    [Column("IVD_Lote")]
    [StringLength(15)]
    [Unicode(false)]
    public string? IvdLote { get; set; }

    [Column("IVD_DataVencimento", TypeName = "smalldatetime")]
    public DateTime? IvdDataVencimento { get; set; }

    [Column("IVD_ComissaoPaga", TypeName = "decimal(15, 0)")]
    public decimal? IvdComissaoPaga { get; set; }

    [Column("IVD_PctComissao", TypeName = "decimal(15, 0)")]
    public decimal? IvdPctComissao { get; set; }

    [Column("IVD_DataEstorno", TypeName = "smalldatetime")]
    public DateTime? IvdDataEstorno { get; set; }

    [Column("IVD_QuantidadeEstorno", TypeName = "decimal(10, 3)")]
    public decimal? IvdQuantidadeEstorno { get; set; }

    [Column("IVD_ValorDevolvido", TypeName = "decimal(15, 5)")]
    public decimal? IvdValorDevolvido { get; set; }

    [Column("IVD_ValorDescontoDevolvido", TypeName = "decimal(15, 2)")]
    public decimal? IvdValorDescontoDevolvido { get; set; }

    [Column("IVD_PctDescontoProduto", TypeName = "decimal(10, 4)")]
    public decimal? IvdPctDescontoProduto { get; set; }

    [Column("IVD_PctDescontoTotal", TypeName = "decimal(15, 2)")]
    public decimal? IvdPctDescontoTotal { get; set; }

    [Column("PRO_Codigo")]
    public int? ProCodigo { get; set; }

    [Column("FAB_Codigo")]
    public short? FabCodigo { get; set; }

    [Column("CLA_Codigo")]
    public short? ClaCodigo { get; set; }

    [Column("LIN_Codigo")]
    public short? LinCodigo { get; set; }

    [Column("CAT_Codigo")]
    public short? CatCodigo { get; set; }

    [Column("TRI_Codigo")]
    public short? TriCodigo { get; set; }

    [Column("USU_Codigo")]
    public int? UsuCodigo { get; set; }

    [Column("USU_Codigo_DescontoProduto")]
    public int? UsuCodigoDescontoProduto { get; set; }

    [Column("PRO_Descricao")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ProDescricao { get; set; }

    [Column("PRO_Apresentacao")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProApresentacao { get; set; }

    [Column("TPV_Codigo")]
    public short? TpvCodigo { get; set; }

    [Column("CON_Codigo")]
    public int? ConCodigo { get; set; }

    [Column("IVD_Historico")]
    [StringLength(100)]
    [Unicode(false)]
    public string? IvdHistorico { get; set; }

    [Column("IVD_SerTecnico")]
    public short? IvdSerTecnico { get; set; }

    [Column("SERPAR_Codigo")]
    public int? SerparCodigo { get; set; }

    [Column("IVD_CodigoNCM")]
    [StringLength(8)]
    [Unicode(false)]
    public string? IvdCodigoNcm { get; set; }

    [Column("IVD_CodExcecao_NCM")]
    [StringLength(4)]
    [Unicode(false)]
    public string? IvdCodExcecaoNcm { get; set; }

    [Column("IVD_STICMS")]
    [StringLength(4)]
    [Unicode(false)]
    public string? IvdSticms { get; set; }

    [Column("IVD_Origem_ICMS")]
    [StringLength(1)]
    [Unicode(false)]
    public string? IvdOrigemIcms { get; set; }

    [Column("IVD_STIPI")]
    [StringLength(4)]
    [Unicode(false)]
    public string? IvdStipi { get; set; }

    [Column("IVD_STPIS")]
    [StringLength(4)]
    [Unicode(false)]
    public string? IvdStpis { get; set; }

    [Column("IVD_STCOFINS")]
    [StringLength(4)]
    [Unicode(false)]
    public string? IvdStcofins { get; set; }

    [Column("IVD_CFOP")]
    [StringLength(5)]
    [Unicode(false)]
    public string? IvdCfop { get; set; }

    [Column("IVD_MsgAdicionais")]
    [StringLength(500)]
    [Unicode(false)]
    public string? IvdMsgAdicionais { get; set; }

    [Column("IVD_Status")]
    public bool? IvdStatus { get; set; }

    [Column("IVD_RedBaseCalcICMS", TypeName = "decimal(15, 2)")]
    public decimal? IvdRedBaseCalcIcms { get; set; }

    [Column("SER_Codigo")]
    public int? SerCodigo { get; set; }

    [Column("PAR_Codigo")]
    public short? ParCodigo { get; set; }

    [Column("PRO_CodigoNCM")]
    [StringLength(8)]
    [Unicode(false)]
    public string? ProCodigoNcm { get; set; }

    [Column("CFOP_Codigo")]
    [StringLength(5)]
    [Unicode(false)]
    public string? CfopCodigo { get; set; }

    [Column("STICMS_Codigo")]
    [StringLength(4)]
    [Unicode(false)]
    public string? SticmsCodigo { get; set; }

    [Column("IVD_SER_Comissao", TypeName = "decimal(15, 2)")]
    public decimal? IvdSerComissao { get; set; }

    [Column("IVD_CodigoANP")]
    [StringLength(9)]
    [Unicode(false)]
    public string? IvdCodigoAnp { get; set; }

    [ForeignKey("IvdSerTecnico")]
    [InverseProperty("ItensVenda")]
    public virtual Usuario? IvdSerTecnicoNavigation { get; set; }

    [ForeignKey("ProCodigo")]
    [InverseProperty("ItensVenda")]
    public virtual Produto? ProCodigoNavigation { get; set; }

    [ForeignKey("SerparCodigo")]
    [InverseProperty("ItensVenda")]
    public virtual SerServicoParte? SerparCodigoNavigation { get; set; }

    [ForeignKey("TpvCodigo")]
    [InverseProperty("ItensVenda")]
    public virtual TipoVendum? TpvCodigoNavigation { get; set; }

    [ForeignKey("VdaCodigo")]
    [InverseProperty("ItensVenda")]
    public virtual Vendum VdaCodigoNavigation { get; set; } = null!;
}
