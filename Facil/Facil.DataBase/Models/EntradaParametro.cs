using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Keyless]
[Table("ENTRADA_PARAMETRO")]
public partial class EntradaParametro
{
    [Column("EPR_UtilizaParametro")]
    public bool? EprUtilizaParametro { get; set; }

    [Column("CLA_Codigo")]
    public short? ClaCodigo { get; set; }

    [Column("FAB_Codigo")]
    public short? FabCodigo { get; set; }

    [Column("TRB_Codigo")]
    public short? TrbCodigo { get; set; }

    [Column("CAT_Codigo")]
    public short? CatCodigo { get; set; }

    [Column("LIN_Codigo")]
    public short? LinCodigo { get; set; }

    [Column("EPR_MargemVenda", TypeName = "decimal(8, 2)")]
    public decimal? EprMargemVenda { get; set; }

    [Column("EPR_GeraEtiqueta")]
    public bool? EprGeraEtiqueta { get; set; }

    [Column("EPR_Loc_CodigoBarra")]
    public bool? EprLocCodigoBarra { get; set; }

    [Column("EPR_Loc_DescricaoProduto")]
    public bool? EprLocDescricaoProduto { get; set; }

    [Column("EPR_Loc_TabelaRelacionamento")]
    public bool? EprLocTabelaRelacionamento { get; set; }

    [Column("EPR_AtualizaMargem")]
    public bool? EprAtualizaMargem { get; set; }

    [Column("EPR_ExibirReferencia")]
    public bool? EprExibirReferencia { get; set; }

    [Column("EPR_Preco_Desconto")]
    public bool? EprPrecoDesconto { get; set; }

    [Column("EPR_Preco_IPI")]
    public bool? EprPrecoIpi { get; set; }

    [Column("EPR_Preco_SubTrib")]
    public bool? EprPrecoSubTrib { get; set; }

    [Column("EPR_Preco_Frete")]
    public bool? EprPrecoFrete { get; set; }

    [Column("EPR_AtualizaNCM")]
    public bool? EprAtualizaNcm { get; set; }

    [Column("EPR_AlteraPreco")]
    public bool? EprAlteraPreco { get; set; }

    [Column("EPR_ExibeValorVendaProd")]
    public bool? EprExibeValorVendaProd { get; set; }

    [Column("EPR_AlteraEstoque")]
    public bool? EprAlteraEstoque { get; set; }

    [Column("EPR_PermiteSemProduto")]
    public bool? EprPermiteSemProduto { get; set; }

    [Column("EPR_Preco_OutrasDesp")]
    public bool? EprPrecoOutrasDesp { get; set; }

    [Column("EPR_UtiMargemProduto")]
    public bool? EprUtiMargemProduto { get; set; }

    [Column("EPR_UtiVlrVendaProduto")]
    public bool? EprUtiVlrVendaProduto { get; set; }
}
