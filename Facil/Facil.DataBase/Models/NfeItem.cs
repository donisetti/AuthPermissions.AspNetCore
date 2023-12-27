using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("NFe_ITEM")]
public partial class NfeItem
{
    [Key]
    [Column("NFI_Codigo")]
    public int NfiCodigo { get; set; }

    [Column("NFE_Codigo")]
    public int NfeCodigo { get; set; }

    [Column("NFI_Quantidade", TypeName = "decimal(10, 3)")]
    public decimal? NfiQuantidade { get; set; }

    [Column("NFI_ValorUnitario", TypeName = "decimal(15, 2)")]
    public decimal? NfiValorUnitario { get; set; }

    [Column("NFI_ValorDesconto", TypeName = "decimal(15, 2)")]
    public decimal? NfiValorDesconto { get; set; }

    [Column("NFI_ValorFrete", TypeName = "decimal(15, 2)")]
    public decimal? NfiValorFrete { get; set; }

    [Column("NFI_ValorSeguro", TypeName = "decimal(15, 2)")]
    public decimal? NfiValorSeguro { get; set; }

    [Column("NFI_ValorOutro", TypeName = "decimal(15, 2)")]
    public decimal? NfiValorOutro { get; set; }

    [Column("FAB_Codigo")]
    public short? FabCodigo { get; set; }

    [Column("CLA_Codigo")]
    public short? ClaCodigo { get; set; }

    [Column("LIN_Codigo")]
    public short? LinCodigo { get; set; }

    [Column("CAT_Codigo")]
    public short? CatCodigo { get; set; }

    [Column("TRB_Codigo")]
    public short? TrbCodigo { get; set; }

    [Column("USU_Codigo")]
    public int? UsuCodigo { get; set; }

    [Column("PRO_Codigo")]
    public int? ProCodigo { get; set; }

    [Column("UNI_Codigo")]
    public int? UniCodigo { get; set; }

    [Column("PRO_Descricao")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ProDescricao { get; set; }

    [Column("PRO_Apresentacao")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProApresentacao { get; set; }

    [Column("PRO_CodigoNCM")]
    [StringLength(8)]
    [Unicode(false)]
    public string? ProCodigoNcm { get; set; }

    [Column("NFI_CodExcecao_NCM")]
    [StringLength(4)]
    [Unicode(false)]
    public string? NfiCodExcecaoNcm { get; set; }

    [Column("CFOP_Codigo")]
    [StringLength(5)]
    [Unicode(false)]
    public string? CfopCodigo { get; set; }

    [Column("STICMS_Codigo")]
    [StringLength(4)]
    [Unicode(false)]
    public string? SticmsCodigo { get; set; }

    [Column("NFI_Origem_ICMS")]
    [StringLength(1)]
    [Unicode(false)]
    public string? NfiOrigemIcms { get; set; }

    [Column("STIPI_Codigo")]
    [StringLength(4)]
    [Unicode(false)]
    public string? StipiCodigo { get; set; }

    [Column("STPIS_Codigo")]
    [StringLength(4)]
    [Unicode(false)]
    public string? StpisCodigo { get; set; }

    [Column("STCOFINS_Codigo")]
    [StringLength(4)]
    [Unicode(false)]
    public string? StcofinsCodigo { get; set; }

    [Column("NFI_RedBaseCalcICMS", TypeName = "decimal(15, 2)")]
    public decimal? NfiRedBaseCalcIcms { get; set; }

    [Column("NFI_BaseCalcICMS", TypeName = "decimal(15, 2)")]
    public decimal? NfiBaseCalcIcms { get; set; }

    [Column("NFI_ValorICMS", TypeName = "decimal(15, 2)")]
    public decimal? NfiValorIcms { get; set; }

    [Column("NFI_BaseCalcICMSST", TypeName = "decimal(15, 2)")]
    public decimal? NfiBaseCalcIcmsst { get; set; }

    [Column("NFI_ValorICMSST", TypeName = "decimal(15, 2)")]
    public decimal? NfiValorIcmsst { get; set; }

    [Column("NFI_DataCadastro", TypeName = "datetime")]
    public DateTime? NfiDataCadastro { get; set; }
}
