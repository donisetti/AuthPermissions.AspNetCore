using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PRODUTO")]
public partial class Produto
{
    [Column("PRO_Cod_Fai")]
    [StringLength(10)]
    [Unicode(false)]
    public string? ProCodFai { get; set; }

    [Key]
    [Column("PRO_Codigo")]
    public int ProCodigo { get; set; }

    [Column("PRO_Cod_Pai")]
    public int? ProCodPai { get; set; }

    [Column("PRO_Cod_Barra")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ProCodBarra { get; set; }

    [Column("PRO_Descricao")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ProDescricao { get; set; }

    [Column("PRO_Apresentacao")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ProApresentacao { get; set; }

    [Column("PRO_Vlr_CustoFabrica", TypeName = "decimal(15, 2)")]
    public decimal? ProVlrCustoFabrica { get; set; }

    [Column("PRO_Vlr_CustoReal", TypeName = "decimal(15, 2)")]
    public decimal? ProVlrCustoReal { get; set; }

    [Column("PRO_Vlr_Venda", TypeName = "decimal(15, 2)")]
    public decimal? ProVlrVenda { get; set; }

    [Column("PRO_Vlr_CustoMedio", TypeName = "decimal(15, 2)")]
    public decimal? ProVlrCustoMedio { get; set; }

    [Column("PRO_Vrl_CustoMedioReal", TypeName = "decimal(15, 2)")]
    public decimal? ProVrlCustoMedioReal { get; set; }

    [Column("PRO_Dta_InicioDescAVista", TypeName = "smalldatetime")]
    public DateTime? ProDtaInicioDescAvista { get; set; }

    [Column("PRO_Dta_FinalDescAVista", TypeName = "smalldatetime")]
    public DateTime? ProDtaFinalDescAvista { get; set; }

    [Column("PRO_Dta_InicioDescAPrazo", TypeName = "smalldatetime")]
    public DateTime? ProDtaInicioDescAprazo { get; set; }

    [Column("PRO_Dta_FinalDescAPrazo", TypeName = "smalldatetime")]
    public DateTime? ProDtaFinalDescAprazo { get; set; }

    [Column("PRO_DataCadastro", TypeName = "smalldatetime")]
    public DateTime? ProDataCadastro { get; set; }

    [Column("PRO_DataAlteracao", TypeName = "smalldatetime")]
    public DateTime? ProDataAlteracao { get; set; }

    [Column("PRO_Pct_ComissaoVista", TypeName = "decimal(5, 2)")]
    public decimal? ProPctComissaoVista { get; set; }

    [Column("PRO_Pct_DescAVista", TypeName = "decimal(5, 2)")]
    public decimal? ProPctDescAvista { get; set; }

    [Column("PRO_Pct_DescAPrazo", TypeName = "decimal(5, 2)")]
    public decimal? ProPctDescAprazo { get; set; }

    [Column("PRO_Pct_ComissaoPrazo", TypeName = "decimal(5, 2)")]
    public decimal? ProPctComissaoPrazo { get; set; }

    [Column("PRO_Pct_Lucro", TypeName = "decimal(15, 2)")]
    public decimal? ProPctLucro { get; set; }

    [Column("PRO_Fracao")]
    public short? ProFracao { get; set; }

    [Column("PRO_Estoque_Minimo", TypeName = "decimal(10, 3)")]
    public decimal? ProEstoqueMinimo { get; set; }

    [Column("PRO_Estoque_Atual", TypeName = "decimal(10, 3)")]
    public decimal? ProEstoqueAtual { get; set; }

    [Column("PRO_Balcao")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ProBalcao { get; set; }

    [Column("PRO_Psicotropico")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ProPsicotropico { get; set; }

    [Column("PRO_UsoContinuo")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ProUsoContinuo { get; set; }

    [Column("PRO_DescAVistaAtivo")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ProDescAvistaAtivo { get; set; }

    [Column("PRO_DescAPrazoAtivo")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ProDescAprazoAtivo { get; set; }

    [Column("BUL_Codigo")]
    public int? BulCodigo { get; set; }

    [Column("LIN_Codigo")]
    public short? LinCodigo { get; set; }

    [Column("FIA_Codigo")]
    public short? FiaCodigo { get; set; }

    [Column("CAT_Codigo")]
    public short? CatCodigo { get; set; }

    [Column("FAB_Codigo")]
    public short? FabCodigo { get; set; }

    [Column("TRB_Codigo")]
    public short? TrbCodigo { get; set; }

    [Column("CLA_Codigo")]
    public short? ClaCodigo { get; set; }

    [Column("PRO_Dta_UltimaAtualizacao", TypeName = "smalldatetime")]
    public DateTime? ProDtaUltimaAtualizacao { get; set; }

    [Column("PRO_CodigoRegistroMS")]
    [StringLength(30)]
    [Unicode(false)]
    public string? ProCodigoRegistroMs { get; set; }

    [Column("PRO_DataExclusao", TypeName = "smalldatetime")]
    public DateTime? ProDataExclusao { get; set; }

    [Column("PRO_DataDesativo", TypeName = "smalldatetime")]
    public DateTime? ProDataDesativo { get; set; }

    [Column("PRO_Referencia")]
    [StringLength(25)]
    [Unicode(false)]
    public string? ProReferencia { get; set; }

    [Column("UNI_Codigo")]
    public short? UniCodigo { get; set; }

    [Column("PRO_Balanca")]
    public bool? ProBalanca { get; set; }

    [Column("TIP_Codigo")]
    public short? TipCodigo { get; set; }

    [Column("PRO_Psi")]
    public bool? ProPsi { get; set; }

    [Column("PRO_CodigoNCM")]
    [StringLength(8)]
    [Unicode(false)]
    public string? ProCodigoNcm { get; set; }

    [Column("PRO_IpiEntrada", TypeName = "decimal(10, 2)")]
    public decimal? ProIpiEntrada { get; set; }

    [Column("PRO_Aplicacao")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ProAplicacao { get; set; }

    [Column("CFOP_Codigo")]
    [StringLength(5)]
    [Unicode(false)]
    public string? CfopCodigo { get; set; }

    [Column("PRO_InformacoesAdicionais")]
    [StringLength(500)]
    [Unicode(false)]
    public string? ProInformacoesAdicionais { get; set; }

    [Column("PRO_CodigoExcecao_NCM")]
    [StringLength(4)]
    [Unicode(false)]
    public string? ProCodigoExcecaoNcm { get; set; }

    [Column("STICMS_Codigo")]
    [StringLength(4)]
    [Unicode(false)]
    public string? SticmsCodigo { get; set; }

    [Column("PRO_Origem_ICMS")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ProOrigemIcms { get; set; }

    [Column("STIPI_Codigo")]
    [StringLength(4)]
    [Unicode(false)]
    public string? StipiCodigo { get; set; }

    [Column("STPIS_Codigo")]
    [StringLength(4)]
    [Unicode(false)]
    public string? StpisCodigo { get; set; }

    [Column("STCOF_Codigo")]
    [StringLength(4)]
    [Unicode(false)]
    public string? StcofCodigo { get; set; }

    [Column("PRO_ValidadeProduto")]
    public int? ProValidadeProduto { get; set; }

    [Column("CLAT_Codigo")]
    public short? ClatCodigo { get; set; }

    [Column("PRO_TipoItem")]
    [StringLength(2)]
    [Unicode(false)]
    public string? ProTipoItem { get; set; }

    [Column("PRO_AliqICMS", TypeName = "decimal(5, 2)")]
    public decimal? ProAliqIcms { get; set; }

    [Column("PRO_Vlr_Venda_Promocao", TypeName = "decimal(15, 2)")]
    public decimal? ProVlrVendaPromocao { get; set; }

    [Column("PRO_Vlr_Venda_Anterior", TypeName = "decimal(15, 2)")]
    public decimal? ProVlrVendaAnterior { get; set; }

    [Column("PRO_Estoque_Reducao", TypeName = "decimal(10, 3)")]
    public decimal? ProEstoqueReducao { get; set; }

    [Column("PROAliqICMS", TypeName = "decimal(5, 2)")]
    public decimal? ProaliqIcms1 { get; set; }

    [Column("PRO_RedBaseCalcICMS", TypeName = "decimal(15, 2)")]
    public decimal? ProRedBaseCalcIcms { get; set; }

    [Column("PRO_Tamanho")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ProTamanho { get; set; }

    [Column("COR_Codigo")]
    public short? CorCodigo { get; set; }

    [Column("EMP_Codigo")]
    public short? EmpCodigo { get; set; }

    [Column("PRO_Ser_Comissao", TypeName = "decimal(15, 2)")]
    public decimal? ProSerComissao { get; set; }

    [Column("CLATMED_Codigo")]
    public short? ClatmedCodigo { get; set; }

    [Column("PRO_CodigoANP")]
    [StringLength(9)]
    [Unicode(false)]
    public string? ProCodigoAnp { get; set; }

    [Column("PRO_FCEP", TypeName = "decimal(15, 4)")]
    public decimal? ProFcep { get; set; }

    [Column("PRO_Cest")]
    [StringLength(8)]
    [Unicode(false)]
    public string? ProCest { get; set; }

    [Column("PRO_cBenef")]
    [StringLength(10)]
    [Unicode(false)]
    public string? ProCBenef { get; set; }

    [Column("PRO_FPop")]
    public bool? ProFpop { get; set; }

    [Column("PRO_Vlr_Atacado", TypeName = "decimal(16, 4)")]
    public decimal? ProVlrAtacado { get; set; }

    [Column("PRO_DifBaseCalcICMS", TypeName = "decimal(15, 2)")]
    public decimal? ProDifBaseCalcIcms { get; set; }

    [Column("PRO_Imagem")]
    public byte[]? ProImagem { get; set; }

    [ForeignKey("BulCodigo")]
    [InverseProperty("Produtos")]
    public virtual Bulario? BulCodigoNavigation { get; set; }

    [ForeignKey("CatCodigo")]
    [InverseProperty("Produtos")]
    public virtual Categorium? CatCodigoNavigation { get; set; }

    [ForeignKey("ClaCodigo")]
    [InverseProperty("Produtos")]
    public virtual Classificacao? ClaCodigoNavigation { get; set; }

    [ForeignKey("ClatCodigo")]
    [InverseProperty("Produtos")]
    public virtual ClasseTerapeutica? ClatCodigoNavigation { get; set; }

    [ForeignKey("ClatmedCodigo")]
    [InverseProperty("Produtos")]
    public virtual ClassificacaoTipoMedicamento? ClatmedCodigoNavigation { get; set; }

    [InverseProperty("ProCodigoNavigation")]
    public virtual ICollection<DevolucaoItem> DevolucaoItems { get; set; } = new List<DevolucaoItem>();

    [InverseProperty("ProCodigoNavigation")]
    public virtual ICollection<EntradaProduto> EntradaProdutos { get; set; } = new List<EntradaProduto>();

    [ForeignKey("FabCodigo")]
    [InverseProperty("Produtos")]
    public virtual Fabricante? FabCodigoNavigation { get; set; }

    [InverseProperty("ProCodigoNavigation")]
    public virtual ICollection<ItensConsignado> ItensConsignados { get; set; } = new List<ItensConsignado>();

    [InverseProperty("ProCodigoNavigation")]
    public virtual ICollection<ItensVendum> ItensVenda { get; set; } = new List<ItensVendum>();

    [ForeignKey("LinCodigo")]
    [InverseProperty("Produtos")]
    public virtual LinhaProduto? LinCodigoNavigation { get; set; }

    [InverseProperty("ProCodigoNavigation")]
    public virtual ICollection<Lote> Lotes { get; set; } = new List<Lote>();

    [InverseProperty("ProCodigoNavigation")]
    public virtual ICollection<PerdaProduto> PerdaProdutos { get; set; } = new List<PerdaProduto>();

    [InverseProperty("ProCodigoNavigation")]
    public virtual ICollection<PetAgendum> PetAgenda { get; set; } = new List<PetAgendum>();

    [InverseProperty("ProCodigoNavigation")]
    public virtual ICollection<ProdutoInventario> ProdutoInventarios { get; set; } = new List<ProdutoInventario>();

    [InverseProperty("ProCodigoNavigation")]
    public virtual ICollection<SaidaProduto> SaidaProdutos { get; set; } = new List<SaidaProduto>();

    [InverseProperty("ProCodigoNavigation")]
    public virtual ICollection<SerCompraItem> SerCompraItems { get; set; } = new List<SerCompraItem>();

    [InverseProperty("ProCodigoNavigation")]
    public virtual ICollection<SubstanciaProduto> SubstanciaProdutos { get; set; } = new List<SubstanciaProduto>();

    [ForeignKey("TipCodigo")]
    [InverseProperty("Produtos")]
    public virtual TipoProduto? TipCodigoNavigation { get; set; }

    [InverseProperty("ProCodigoNavigation")]
    public virtual ICollection<TransferenciaProduto> TransferenciaProdutos { get; set; } = new List<TransferenciaProduto>();

    [ForeignKey("TrbCodigo")]
    [InverseProperty("Produtos")]
    public virtual Tributacao? TrbCodigoNavigation { get; set; }

    [InverseProperty("ProCodigoNavigation")]
    public virtual ICollection<VendaLote> VendaLotes { get; set; } = new List<VendaLote>();
}
