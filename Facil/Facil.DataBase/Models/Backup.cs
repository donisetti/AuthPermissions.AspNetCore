using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("BACKUPS")]
public partial class Backup
{
    [Key]
    [Column("BAK_Codigo")]
    public short BakCodigo { get; set; }

    [Column("BAK_IPServidor")]
    [StringLength(15)]
    [Unicode(false)]
    public string? BakIpservidor { get; set; }

    [Column("BAK_Data", TypeName = "smalldatetime")]
    public DateTime? BakData { get; set; }

    [Column("BAK_Status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? BakStatus { get; set; }

    [Column("BAK_NumeroEstacao")]
    public short? BakNumeroEstacao { get; set; }

    [Column("BAK_NomeEstacao")]
    [StringLength(15)]
    [Unicode(false)]
    public string? BakNomeEstacao { get; set; }

    [Column("EMP_Codigo")]
    public short? EmpCodigo { get; set; }

    [Column("CXO_Codigo")]
    public int? CxoCodigo { get; set; }

    [Column("CXA_Codigo")]
    public short? CxaCodigo { get; set; }

    [Column("BAK_ImpressoraConfigurada")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BakImpressoraConfigurada { get; set; }

    [Column("BAK_ModeloImpressoraCodigoBarras")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BakModeloImpressoraCodigoBarras { get; set; }

    [Column("BAK_QuantidadeLinhaCupom40")]
    [StringLength(2)]
    [Unicode(false)]
    public string? BakQuantidadeLinhaCupom40 { get; set; }

    [Column("BAK_QuantidadeLinhaCupom80")]
    [StringLength(2)]
    [Unicode(false)]
    public string? BakQuantidadeLinhaCupom80 { get; set; }

    [Column("BAK_ImprimePromissoriaCupom40")]
    public bool? BakImprimePromissoriaCupom40 { get; set; }

    [Column("BAK_ImprimePromissoriaCupom40SimNao")]
    public bool? BakImprimePromissoriaCupom40SimNao { get; set; }

    [Column("BAK_ImprimeDescontoCupom")]
    public bool? BakImprimeDescontoCupom { get; set; }

    [Column("BAK_ControlaCaixaOperador")]
    public bool? BakControlaCaixaOperador { get; set; }

    [Column("BAK_ImprimirCupom")]
    public bool? BakImprimirCupom { get; set; }

    [Column("BAK_SolicitarImprimirSimNao")]
    public bool? BakSolicitarImprimirSimNao { get; set; }

    [Column("BAK_ImprimirEm_Cupom40Colunas")]
    public bool? BakImprimirEmCupom40Colunas { get; set; }

    [Column("BAK_ModeloCupom_MATRICIAL_HP")]
    [StringLength(1)]
    [Unicode(false)]
    public string? BakModeloCupomMatricialHp { get; set; }

    [Column("BAK_ModeloOrcamento_MATRICIAL_HP")]
    [StringLength(1)]
    [Unicode(false)]
    public string? BakModeloOrcamentoMatricialHp { get; set; }

    [Column("BAK_ViasReimpressao")]
    [StringLength(1)]
    [Unicode(false)]
    public string? BakViasReimpressao { get; set; }

    [Column("BAK_NomePortaSerial")]
    [StringLength(10)]
    [Unicode(false)]
    public string? BakNomePortaSerial { get; set; }

    [Column("BAK_Paridade")]
    [StringLength(1)]
    [Unicode(false)]
    public string? BakParidade { get; set; }

    [Column("BAK_BaudRate")]
    public int? BakBaudRate { get; set; }

    [Column("BAK_DataBits")]
    public short? BakDataBits { get; set; }

    [Column("BAK_StopBits")]
    [StringLength(1)]
    [Unicode(false)]
    public string? BakStopBits { get; set; }

    [Column("BAK_ImpressoraConfiguradaEtiqueta")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BakImpressoraConfiguradaEtiqueta { get; set; }

    [Column("BAK_ModeloEtiqueta")]
    [StringLength(2)]
    [Unicode(false)]
    public string? BakModeloEtiqueta { get; set; }

    [Column("BAK_UsarArredondamentoIF")]
    public bool? BakUsarArredondamentoIf { get; set; }

    [Column("BAK_NomeBalancaCheckout")]
    [StringLength(30)]
    [Unicode(false)]
    public string? BakNomeBalancaCheckout { get; set; }

    [Column("BAK_UsaNF")]
    public int? BakUsaNf { get; set; }

    [Column("BAK_ModeloCupomConsignado_MATRICIAL_HP")]
    [StringLength(1)]
    [Unicode(false)]
    public string? BakModeloCupomConsignadoMatricialHp { get; set; }

    [Column("BAK_PortaSerialECF")]
    [StringLength(8)]
    [Unicode(false)]
    public string? BakPortaSerialEcf { get; set; }

    [Column("BAK_Bloqueada")]
    public int? BakBloqueada { get; set; }

    [Column("BAK_EmiteNfce")]
    public bool? BakEmiteNfce { get; set; }

    [Column("BAK_ImpFisicaCodigo")]
    public bool? BakImpFisicaCodigo { get; set; }

    [Column("BAK_IMPFisicaPortaCom")]
    [StringLength(1)]
    [Unicode(false)]
    public string? BakImpfisicaPortaCom { get; set; }

    [Column("BAK_EmiteNFe")]
    public bool? BakEmiteNfe { get; set; }

    [Column("BAK_ImprimeNotaPromissoria")]
    public bool? BakImprimeNotaPromissoria { get; set; }

    [Column("BAK_SerieNFCe")]
    public short? BakSerieNfce { get; set; }

    [Column("BAK_UltimaNFCe")]
    public long? BakUltimaNfce { get; set; }

    [Column("BAK_QtdVias_Relatorio")]
    public short? BakQtdViasRelatorio { get; set; }

    [Column("BAK_MeiaFolhaA4_Orcamento")]
    public bool? BakMeiaFolhaA4Orcamento { get; set; }

    [Column("BAK_PesquisarClientePorCodigo")]
    public bool? BakPesquisarClientePorCodigo { get; set; }

    [Column("BAK_AlterarValorVenda")]
    public bool? BakAlterarValorVenda { get; set; }

    [Column("BAK_AtualizaSchemas")]
    public bool? BakAtualizaSchemas { get; set; }

    [Column("BAK_EmiteCte")]
    public bool? BakEmiteCte { get; set; }

    [Column("BAK_HabilitarPedidoMesa")]
    public bool? BakHabilitarPedidoMesa { get; set; }

    [Column("BAK_UsarPedidoCozinha")]
    public bool? BakUsarPedidoCozinha { get; set; }

    [Column("BAK_EmiteCTeOS")]
    public bool? BakEmiteCteOs { get; set; }

    [Column("BAK_TEF_NumeroPDV")]
    [StringLength(3)]
    [Unicode(false)]
    public string? BakTefNumeroPdv { get; set; }

    [Column("BAK_TEF_CaminhoComprovante")]
    [StringLength(100)]
    [Unicode(false)]
    public string? BakTefCaminhoComprovante { get; set; }

    [Column("PAR_PerguntaImpressaoTEF")]
    public bool? ParPerguntaImpressaoTef { get; set; }

    [Column("BAK_EmiteCFe")]
    public bool? BakEmiteCfe { get; set; }

    [Column("BAK_NumCaixaCFe")]
    [StringLength(3)]
    [Unicode(false)]
    public string? BakNumCaixaCfe { get; set; }

    [Column("BAK_CodigoAtivacao")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BakCodigoAtivacao { get; set; }

    [Column("BAK_SomenteFazComanda")]
    public bool? BakSomenteFazComanda { get; set; }

    [InverseProperty("BakCodigoNavigation")]
    public virtual ICollection<FormaPagamentoImpressora> FormaPagamentoImpressoras { get; set; } = new List<FormaPagamentoImpressora>();
}
