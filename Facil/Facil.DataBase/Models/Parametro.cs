using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Keyless]
[Table("PARAMETRO")]
public partial class Parametro
{
    [Column("PAR_VendaEstoqueNegativo")]
    public bool? ParVendaEstoqueNegativo { get; set; }

    [Column("PAR_ReceberCobraJuros")]
    public bool? ParReceberCobraJuros { get; set; }

    [Column("PAR_ReceberPctJuros", TypeName = "decimal(5, 2)")]
    public decimal? ParReceberPctJuros { get; set; }

    [Column("PAR_ReceberDiasCobrarJuros")]
    public short? ParReceberDiasCobrarJuros { get; set; }

    [Column("PAR_Versao")]
    [StringLength(10)]
    [Unicode(false)]
    public string? ParVersao { get; set; }

    [Column("PAR_Serial")]
    [StringLength(5)]
    [Unicode(false)]
    public string? ParSerial { get; set; }

    [Column("PAR_DataAtualizacaoProduto", TypeName = "smalldatetime")]
    public DateTime? ParDataAtualizacaoProduto { get; set; }

    [Column("PAR_SerialKey")]
    [StringLength(12)]
    [Unicode(false)]
    public string? ParSerialKey { get; set; }

    [Column("PAR_SenhaLiberacao")]
    [StringLength(10)]
    [Unicode(false)]
    public string? ParSenhaLiberacao { get; set; }

    [Column("PAR_AtendimentoContasVencidas")]
    public bool? ParAtendimentoContasVencidas { get; set; }

    [Column("PAR_AtendimentoDiasContasVencidas")]
    public short? ParAtendimentoDiasContasVencidas { get; set; }

    [Column("PAR_ControlaLimiteCredito")]
    public bool? ParControlaLimiteCredito { get; set; }

    [Column("PAR_DescontoFechamentoVenda", TypeName = "decimal(5, 2)")]
    public decimal? ParDescontoFechamentoVenda { get; set; }

    [Column("PAR_MSGCupomCabec")]
    [StringLength(40)]
    [Unicode(false)]
    public string? ParMsgcupomCabec { get; set; }

    [Column("PAR_ContaReceitaBranca")]
    public int? ParContaReceitaBranca { get; set; }

    [Column("PAR_PCtAcrescimo", TypeName = "decimal(5, 2)")]
    public decimal? ParPctAcrescimo { get; set; }

    [Column("PAR_SenhaLiberacaoEstorno")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ParSenhaLiberacaoEstorno { get; set; }

    [Column("PAR_MostraMensagemAtendimento")]
    public bool? ParMostraMensagemAtendimento { get; set; }

    [Column("PAR_ImprimePromissoriaCupom40")]
    public bool? ParImprimePromissoriaCupom40 { get; set; }

    [Column("PAR_ImprimePromissoriaCupom40SimNao")]
    public bool? ParImprimePromissoriaCupom40SimNao { get; set; }

    [Column("PAR_ImprimeDescontoCupom")]
    public bool? ParImprimeDescontoCupom { get; set; }

    [Column("PAR_ControlaSenhaAtendente")]
    public bool? ParControlaSenhaAtendente { get; set; }

    [Column("PAR_CaminhoBackup")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ParCaminhoBackup { get; set; }

    [Column("PAR_ControlaVencimentoLote")]
    public bool? ParControlaVencimentoLote { get; set; }

    [Column("PAR_AnoExercicio")]
    [StringLength(4)]
    [Unicode(false)]
    public string? ParAnoExercicio { get; set; }

    [Column("PAR_CadastroClienteIncompletoCpfCnpj")]
    public bool? ParCadastroClienteIncompletoCpfCnpj { get; set; }

    [Column("PAR_ProdutoReferenciaDuplicado")]
    public bool? ParProdutoReferenciaDuplicado { get; set; }

    [Column("PAR_ControlarSenhaFechamentoCaixa")]
    public bool? ParControlarSenhaFechamentoCaixa { get; set; }

    [Column("PAR_MSGCupomRodape")]
    [StringLength(150)]
    [Unicode(false)]
    public string? ParMsgcupomRodape { get; set; }

    [Column("PAR_EmpTipo")]
    [StringLength(3)]
    [Unicode(false)]
    public string? ParEmpTipo { get; set; }

    [Column("EMP_Codigo")]
    public short? EmpCodigo { get; set; }

    [Column("PAR_ControlaUnidadeMedida")]
    public bool? ParControlaUnidadeMedida { get; set; }

    [Column("PAR_ControlaCaixaOperador")]
    public bool? ParControlaCaixaOperador { get; set; }

    [Column("PAR_ZerarSaldoContaCaixa")]
    public bool? ParZerarSaldoContaCaixa { get; set; }

    [Column("PAR_ServicoBackup")]
    public bool? ParServicoBackup { get; set; }

    [Column("PAR_ControleEntrega")]
    public bool? ParControleEntrega { get; set; }

    [Column("PAR_ObrigaEntradaMS")]
    public bool? ParObrigaEntradaMs { get; set; }

    [Column("PAR_SuporteImpressaoEtiqueta")]
    public bool? ParSuporteImpressaoEtiqueta { get; set; }

    [Column("PAR_SuporteImpressao40Colunas")]
    public bool? ParSuporteImpressao40Colunas { get; set; }

    [Column("PAR_FPopularAmbienteProducao")]
    public bool? ParFpopularAmbienteProducao { get; set; }

    [Column("PAR_SuporteImpressaoHpControleEntrega")]
    public bool? ParSuporteImpressaoHpControleEntrega { get; set; }

    [Column("PAR_ExecutarServicosPet")]
    public bool? ParExecutarServicosPet { get; set; }

    [Column("PAR_Count")]
    public short? ParCount { get; set; }

    [Column("PAR_FPopSuporteSenhaVendedor")]
    public bool? ParFpopSuporteSenhaVendedor { get; set; }

    [Column("PAR_DataSistema", TypeName = "smalldatetime")]
    public DateTime? ParDataSistema { get; set; }

    [Column("PAR_DescricaoErro")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ParDescricaoErro { get; set; }

    [Column("PAR_ExecutarServicosFacil")]
    public bool? ParExecutarServicosFacil { get; set; }

    [Column("PAR_UsaIF")]
    public int? ParUsaIf { get; set; }

    [Column("PAR_COPS_DiasControle")]
    public int? ParCopsDiasControle { get; set; }

    [Column("PAR_ExecutarServicosCOPS")]
    public bool? ParExecutarServicosCops { get; set; }

    [Column("PAR_XCODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ParXcode { get; set; }

    [Column("PAR_BitCount")]
    public bool? ParBitCount { get; set; }

    [Column("PAR_Frase_1_Cupom_80_Colunas")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ParFrase1Cupom80Colunas { get; set; }

    [Column("PAR_Frase_2_Cupom_80_Colunas")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ParFrase2Cupom80Colunas { get; set; }

    [Column("PAR_ImprimirMSGDesconto")]
    public bool? ParImprimirMsgdesconto { get; set; }

    [Column("PAR_ImprimirAssinatura80Coluna")]
    public bool? ParImprimirAssinatura80Coluna { get; set; }

    [Column("PAR_DimensionarImgRelVenda")]
    public bool? ParDimensionarImgRelVenda { get; set; }

    [Column("PAR_MenuEspecialCaixa")]
    public bool? ParMenuEspecialCaixa { get; set; }

    [Column("PAR_AtendimentoCadastroProduto")]
    public bool? ParAtendimentoCadastroProduto { get; set; }

    [Column("PAR_PermitirAtalhoAtendimento")]
    public bool? ParPermitirAtalhoAtendimento { get; set; }

    [Column("PAR_ValorFabricaProduto")]
    public bool? ParValorFabricaProduto { get; set; }

    [Column("PAR_PercentualVendaProduto")]
    public bool? ParPercentualVendaProduto { get; set; }

    [Column("PAR_Baixa_BotaoImprimir")]
    public bool? ParBaixaBotaoImprimir { get; set; }

    [Column("PAR_FormaPagamento")]
    public short? ParFormaPagamento { get; set; }

    [Column("PAR_QtdeDigitosBalanca")]
    public short? ParQtdeDigitosBalanca { get; set; }

    [Column("PAR_AbrirGaveta")]
    public bool? ParAbrirGaveta { get; set; }

    [Column("PAR_BloquearEstoqueAtendimento")]
    public bool? ParBloquearEstoqueAtendimento { get; set; }

    [Column("PAR_ExecutarServicosFacilAuto")]
    public bool? ParExecutarServicosFacilAuto { get; set; }

    [Column("PAR_ImpressaoDadosClienteCupom")]
    public bool? ParImpressaoDadosClienteCupom { get; set; }

    [Column("PAR_AtendimentoContasReceber")]
    public bool? ParAtendimentoContasReceber { get; set; }

    [Column("PAR_ControlarChequeRecebimento")]
    public bool? ParControlarChequeRecebimento { get; set; }

    [Column("PAR_PermitirEstornoVendaAtendimento")]
    public bool? ParPermitirEstornoVendaAtendimento { get; set; }

    [Column("PAR_SequencialNovartis")]
    public int? ParSequencialNovartis { get; set; }

    [Column("PAR_EmiteNfe")]
    public bool? ParEmiteNfe { get; set; }

    [Column("PAR_PreencherDataVencimento")]
    public bool? ParPreencherDataVencimento { get; set; }

    [Column("PAR_ManterCamposPrecos")]
    public bool? ParManterCamposPrecos { get; set; }

    [Column("PAR_ManterCamposApresentacao")]
    public bool? ParManterCamposApresentacao { get; set; }

    [Column("PAR_TelaRecebimento")]
    public int? ParTelaRecebimento { get; set; }

    [Column("PAR_F10_Venda_Orcamento")]
    public bool? ParF10VendaOrcamento { get; set; }

    [Column("PAR_EtiImprimirValorVenda")]
    public bool? ParEtiImprimirValorVenda { get; set; }

    [Column("PAR_BloquearClienteDiasAtraso")]
    public short? ParBloquearClienteDiasAtraso { get; set; }

    [Column("PAR_GravarBotoesPesquisaAtendimento")]
    public bool? ParGravarBotoesPesquisaAtendimento { get; set; }

    [Column("PAR_PorReferencia")]
    public bool? ParPorReferencia { get; set; }

    [Column("PAR_ControlarDescontoPessoaClassificacao")]
    public bool? ParControlarDescontoPessoaClassificacao { get; set; }

    [Column("PAR_CadastroClienteIncompletoRg")]
    public bool? ParCadastroClienteIncompletoRg { get; set; }

    [Column("PAR_CadastroClienteIncompletoEndereco")]
    public bool? ParCadastroClienteIncompletoEndereco { get; set; }

    [Column("PAR_ExecutarServicoLocacao")]
    public bool? ParExecutarServicoLocacao { get; set; }

    [Column("PAR_UsarNumeroPedidoVenda")]
    public bool? ParUsarNumeroPedidoVenda { get; set; }

    [Column("PAR_SequencialEPharma")]
    public int? ParSequencialEpharma { get; set; }

    [Column("PAR_UtilizarLancamentoPerda")]
    public bool? ParUtilizarLancamentoPerda { get; set; }

    [Column("PAR_SngpcAmbienteProducao")]
    public bool? ParSngpcAmbienteProducao { get; set; }

    [Column("PAR_PreencherNumDiasDataVencimento")]
    public int? ParPreencherNumDiasDataVencimento { get; set; }

    [Column("PAR_UsaNf")]
    [StringLength(10)]
    [Unicode(false)]
    public string? ParUsaNf { get; set; }

    [Column("PAR_IncluirBoletoContasReceber")]
    public bool? ParIncluirBoletoContasReceber { get; set; }

    [Column("PAR_UsarControleUsuario")]
    public bool? ParUsarControleUsuario { get; set; }

    [Column("PAR_UsarControleCartao")]
    public bool? ParUsarControleCartao { get; set; }

    [Column("PAR_NumeroCartao")]
    [StringLength(7)]
    [Unicode(false)]
    public string? ParNumeroCartao { get; set; }

    [Column("PAR_ImprimirModoNormalComprimido")]
    public bool? ParImprimirModoNormalComprimido { get; set; }

    [Column("PAR_UsaReplicador")]
    public bool? ParUsaReplicador { get; set; }

    [Column("PAR_UsaLinhaAgrupamento")]
    public bool? ParUsaLinhaAgrupamento { get; set; }

    [Column("PAR_RelatorioGerencialTodaVenda")]
    public bool? ParRelatorioGerencialTodaVenda { get; set; }

    [Column("PAR_RelatorioGerencialVendaPrazoParcelada")]
    public bool? ParRelatorioGerencialVendaPrazoParcelada { get; set; }

    [Column("PAR_ImprimirPromissoriaConsignadoHp")]
    public bool? ParImprimirPromissoriaConsignadoHp { get; set; }

    [Column("PAR_UsaTEF")]
    public bool? ParUsaTef { get; set; }

    [Column("PAR_CaminhoPastaTef")]
    [StringLength(80)]
    [Unicode(false)]
    public string? ParCaminhoPastaTef { get; set; }

    [Column("PAR_CaminhoGerenciadorTef")]
    [StringLength(80)]
    [Unicode(false)]
    public string? ParCaminhoGerenciadorTef { get; set; }

    [Column("PAR_ControlaSenhaContasReceber")]
    public bool? ParControlaSenhaContasReceber { get; set; }

    [Column("PAR_CaminhoReplicador")]
    [StringLength(250)]
    [Unicode(false)]
    public string? ParCaminhoReplicador { get; set; }

    [Column("PAR_NomeEmpresaEtiqueta")]
    [StringLength(35)]
    [Unicode(false)]
    public string? ParNomeEmpresaEtiqueta { get; set; }

    [Column("PAR_ImprimirCupomVendaComEntrada")]
    public bool? ParImprimirCupomVendaComEntrada { get; set; }

    [Column("PAR_PermitirEstornoItem")]
    public bool? ParPermitirEstornoItem { get; set; }

    [Column("PAR_BloquearClienteDiasAtrasoAutomatico")]
    public short? ParBloquearClienteDiasAtrasoAutomatico { get; set; }

    [Column("PAR_ImprimirControleEntrega")]
    public bool? ParImprimirControleEntrega { get; set; }

    [Column("PAR_Concomitante")]
    public bool? ParConcomitante { get; set; }

    [Column("PAR_UsaSolucaoBematech")]
    public bool? ParUsaSolucaoBematech { get; set; }

    [Column("PAR_UtilizaNumeroOrdem")]
    public bool? ParUtilizaNumeroOrdem { get; set; }

    [Column("PAR__UsaSolucaoBematech")]
    public bool? ParUsaSolucaoBematech1 { get; set; }

    [Column("PAR_EmiteNfce")]
    public bool? ParEmiteNfce { get; set; }

    [Column("PAR_QuantidadeMaxima", TypeName = "decimal(10, 3)")]
    public decimal? ParQuantidadeMaxima { get; set; }

    [Column("PAR_ValorVendaMaximo", TypeName = "decimal(15, 2)")]
    public decimal? ParValorVendaMaximo { get; set; }

    [Column("PAR_TelaAtendimento")]
    public int? ParTelaAtendimento { get; set; }

    [Column("ReplicaCadastros_Cliente_Produto")]
    public bool? ReplicaCadastrosClienteProduto { get; set; }

    [Column("PAR_ExecutarFacilMesas")]
    public bool? ParExecutarFacilMesas { get; set; }

    [Column("PAR_EmiteReferenciaEtiqueta")]
    public bool? ParEmiteReferenciaEtiqueta { get; set; }

    [Column("PAR_UsarCodigoDiversosAtendimento")]
    public bool? ParUsarCodigoDiversosAtendimento { get; set; }

    [Column("PAR_ImprimirDuasViasRecebimento")]
    public bool? ParImprimirDuasViasRecebimento { get; set; }

    [Column("PAR_Impressora_RestBar_Pedido_Outros")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ParImpressoraRestBarPedidoOutros { get; set; }

    [Column("PAR_UsarControleUsuarioLiberacaoVenda")]
    public bool? ParUsarControleUsuarioLiberacaoVenda { get; set; }

    [Column("PAR_EnviarDocFiscal")]
    public bool? ParEnviarDocFiscal { get; set; }

    [Column("PAR_GerarChaveDoacao")]
    public bool? ParGerarChaveDoacao { get; set; }

    [Column("PAR_PesquisarClientePorCodigo")]
    public bool? ParPesquisarClientePorCodigo { get; set; }

    [Column("PAR_UsarCadastroGrade")]
    public bool? ParUsarCadastroGrade { get; set; }

    [Column("PAR_ReiniciarDocFiscal")]
    public bool? ParReiniciarDocFiscal { get; set; }

    [Column("PAR_DataReinicioDocFiscal")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ParDataReinicioDocFiscal { get; set; }

    [Column("PAR_UsarEmpRazaoNomeLog")]
    public bool? ParUsarEmpRazaoNomeLog { get; set; }

    [Column("PAR_CadastroClienteIncompleto")]
    public bool? ParCadastroClienteIncompleto { get; set; }

    [Column("PAR_ImprimirRecibobaixa")]
    public short? ParImprimirRecibobaixa { get; set; }

    [Column("PAR_EntrouEmContingencia")]
    public short? ParEntrouEmContingencia { get; set; }

    [Column("PAR_NomeBackup")]
    [StringLength(30)]
    [Unicode(false)]
    public string? ParNomeBackup { get; set; }

    [Column("PAR_DataBackup", TypeName = "smalldatetime")]
    public DateTime? ParDataBackup { get; set; }

    [Column("PAR_DataEnvioEmailBackup", TypeName = "smalldatetime")]
    public DateTime? ParDataEnvioEmailBackup { get; set; }

    [Column("PAR_EnviarEmailBackup")]
    public bool? ParEnviarEmailBackup { get; set; }

    [Column("PAR_GerandoBackup")]
    public bool? ParGerandoBackup { get; set; }

    [Column("PAR_Impressora_RestBar_Pedido_Cozinha")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ParImpressoraRestBarPedidoCozinha { get; set; }

    [Column("PAR_AtualizaEstoqueEmitirNFeAvulsa")]
    public bool? ParAtualizaEstoqueEmitirNfeAvulsa { get; set; }

    [Column("PAR_UsarServicosGrafica")]
    public bool? ParUsarServicosGrafica { get; set; }

    [Column("PAR_ImprimirItensVendidosCupom")]
    public bool? ParImprimirItensVendidosCupom { get; set; }

    [Column("PAR_UsaRelPisCofinsIcms")]
    public bool? ParUsaRelPisCofinsIcms { get; set; }

    [Column("PAR_NFeDestDirPDF")]
    [StringLength(250)]
    [Unicode(false)]
    public string? ParNfeDestDirPdf { get; set; }

    [Column("PAR_NFeDestDirBackup")]
    [StringLength(250)]
    [Unicode(false)]
    public string? ParNfeDestDirBackup { get; set; }

    public bool? UsarPedidoCozinhaAtendimento { get; set; }

    [Column("PAR_UsarValorAtacado")]
    public bool? ParUsarValorAtacado { get; set; }

    [Column("PAR_MostrarMargemVdaDiaria")]
    public bool? ParMostrarMargemVdaDiaria { get; set; }

    [Column("PAR_MostrarCodigoZeroVdaDiaria")]
    public bool? ParMostrarCodigoZeroVdaDiaria { get; set; }

    [Column("PAR_EtiImprimirValorVendaCustoEti")]
    public bool? ParEtiImprimirValorVendaCustoEti { get; set; }

    [Column("PAR_LogoTipoRecebimentoTermica")]
    [StringLength(150)]
    [Unicode(false)]
    public string? ParLogoTipoRecebimentoTermica { get; set; }

    [Column("PAR_LogoTipoNFeA4")]
    [StringLength(150)]
    [Unicode(false)]
    public string? ParLogoTipoNfeA4 { get; set; }

    [Column("PAR_ValidarDadosNFe")]
    public bool? ParValidarDadosNfe { get; set; }

    [Column("PAR_CadastroApp")]
    public bool? ParCadastroApp { get; set; }

    [Column("PAR_EnviarEmailNfceBk")]
    public bool? ParEnviarEmailNfceBk { get; set; }

    [Column("PAR_AtivarBk")]
    public bool? ParAtivarBk { get; set; }

    [Column("PAR_TempoGerarBk")]
    public double? ParTempoGerarBk { get; set; }

    [Column("PAR_ExecutarServicoHotel")]
    public bool? ParExecutarServicoHotel { get; set; }

    [Column("PAR_AtualizaEstoqueNaEmissaoNotaFiscalAvulsa")]
    public bool? ParAtualizaEstoqueNaEmissaoNotaFiscalAvulsa { get; set; }

    [Column("PAR_NFeDestEnviaEmail")]
    public bool? ParNfeDestEnviaEmail { get; set; }

    [Column("PAR_AssinaturaSoftwareHouse")]
    [StringLength(500)]
    [Unicode(false)]
    public string? ParAssinaturaSoftwareHouse { get; set; }

    [Column("PAR_CnpjSoftwareHouse")]
    [StringLength(14)]
    [Unicode(false)]
    public string? ParCnpjSoftwareHouse { get; set; }

    [Column("PAR_CodigoUF")]
    [StringLength(2)]
    [Unicode(false)]
    public string? ParCodigoUf { get; set; }

    [Column("PAR_VersaoCFe")]
    [StringLength(8)]
    [Unicode(false)]
    public string? ParVersaoCfe { get; set; }

    [Column("PAR_LogoMdiTela")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ParLogoMdiTela { get; set; }

    [Column("PAR_EnvioBkFTP")]
    public bool? ParEnvioBkFtp { get; set; }

    [Column("PAR_DtEnvioBkFTP", TypeName = "smalldatetime")]
    public DateTime? ParDtEnvioBkFtp { get; set; }

    [Column("PAR_NomeBKZip")]
    [StringLength(75)]
    [Unicode(false)]
    public string? ParNomeBkzip { get; set; }

    [Column("PAR_EnviandoBkFtp")]
    public bool? ParEnviandoBkFtp { get; set; }

    [Column("PAR_BloqueiaCliDiasUltimaCompra")]
    public int? ParBloqueiaCliDiasUltimaCompra { get; set; }

    [Column("PAR_UsaControleComanda")]
    public bool? ParUsaControleComanda { get; set; }

    [Column("PAR_ImprimirCupomAposFiscal")]
    public bool? ParImprimirCupomAposFiscal { get; set; }

    [Column("PAR_HabilitarAPP")]
    public bool? ParHabilitarApp { get; set; }
}
