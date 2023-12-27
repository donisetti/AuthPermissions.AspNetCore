using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("VENDA")]
public partial class Vendum
{
    [Key]
    [Column("VDA_Codigo")]
    public long VdaCodigo { get; set; }

    [Column("VDA_DataLancamento", TypeName = "smalldatetime")]
    public DateTime VdaDataLancamento { get; set; }

    [Column("VDA_Historico")]
    [StringLength(40)]
    [Unicode(false)]
    public string? VdaHistorico { get; set; }

    [Column("VDA_Cupom")]
    public long? VdaCupom { get; set; }

    [Column("VDA_Valor", TypeName = "decimal(15, 2)")]
    public decimal? VdaValor { get; set; }

    [Column("VDA_DescontoTotal", TypeName = "decimal(15, 2)")]
    public decimal? VdaDescontoTotal { get; set; }

    [Column("VDA_Parcelas")]
    public short? VdaParcelas { get; set; }

    [Column("VDA_NumeroECF")]
    public short? VdaNumeroEcf { get; set; }

    [Column("VDA_ValorDevolvido", TypeName = "decimal(15, 2)")]
    public decimal? VdaValorDevolvido { get; set; }

    [Column("VDA_ValorDescontoDevolucao", TypeName = "decimal(15, 2)")]
    public decimal? VdaValorDescontoDevolucao { get; set; }

    [Column("VDA_CodigoVendedor")]
    public short VdaCodigoVendedor { get; set; }

    [Column("USR_UsuarioSistema")]
    public short? UsrUsuarioSistema { get; set; }

    [Column("PES_CODIGO")]
    public int PesCodigo { get; set; }

    [Column("VDA_DataEstorno", TypeName = "smalldatetime")]
    public DateTime? VdaDataEstorno { get; set; }

    [Column("VDA_UsuarioEstorno")]
    public short? VdaUsuarioEstorno { get; set; }

    [Column("VDA_PctDescontoTotal", TypeName = "decimal(10, 4)")]
    public decimal? VdaPctDescontoTotal { get; set; }

    [Column("VDA_NomeCliente")]
    [StringLength(60)]
    [Unicode(false)]
    public string? VdaNomeCliente { get; set; }

    [Column("VDA_ControlaEntrega")]
    [StringLength(1)]
    [Unicode(false)]
    public string? VdaControlaEntrega { get; set; }

    [Column("VDA_PossuiEstorno")]
    public bool VdaPossuiEstorno { get; set; }

    [Column("EMP_Codigo")]
    public short? EmpCodigo { get; set; }

    [Column("TPV_Codigo")]
    public short? TpvCodigo { get; set; }

    [Column("SER_Codigo")]
    public int? SerCodigo { get; set; }

    [Column("VDA_ValorHaver", TypeName = "decimal(15, 4)")]
    public decimal? VdaValorHaver { get; set; }

    [Column("VDA_NumeroPedido")]
    public int? VdaNumeroPedido { get; set; }

    [Column("VDA_SituacaoEnvio")]
    [StringLength(1)]
    [Unicode(false)]
    public string? VdaSituacaoEnvio { get; set; }

    [Column("VDA_NumeroNFe")]
    public int? VdaNumeroNfe { get; set; }

    [Column("VDA_Status")]
    [StringLength(3)]
    [Unicode(false)]
    public string? VdaStatus { get; set; }

    [Column("ORC_Codigo")]
    public long? OrcCodigo { get; set; }

    [Column("USR_CodigoLiberouVenda")]
    public short? UsrCodigoLiberouVenda { get; set; }

    [Column("VOR_Codigo")]
    public short? VorCodigo { get; set; }

    [InverseProperty("VdaCodigoNavigation")]
    public virtual ICollection<Cheque> Cheques { get; set; } = new List<Cheque>();

    [InverseProperty("VdaCodigoNavigation")]
    public virtual ICollection<ContasReceber> ContasRecebers { get; set; } = new List<ContasReceber>();

    [InverseProperty("VdaCodigoNavigation")]
    public virtual ICollection<Devolucao> Devolucaos { get; set; } = new List<Devolucao>();

    [InverseProperty("VdaCodigoNavigation")]
    public virtual ICollection<EnderecoEntrega> EnderecoEntregas { get; set; } = new List<EnderecoEntrega>();

    [InverseProperty("VdaCodigoNavigation")]
    public virtual ICollection<ItensConsignado> ItensConsignados { get; set; } = new List<ItensConsignado>();

    [InverseProperty("VdaCodigoNavigation")]
    public virtual ICollection<ItensVendum> ItensVenda { get; set; } = new List<ItensVendum>();

    [InverseProperty("VdaCodigoNavigation")]
    public virtual ICollection<NfeNotaCupom> NfeNotaCupoms { get; set; } = new List<NfeNotaCupom>();

    [ForeignKey("OrcCodigo")]
    [InverseProperty("Venda")]
    public virtual Orcamento? OrcCodigoNavigation { get; set; }

    [ForeignKey("PesCodigo")]
    [InverseProperty("Venda")]
    public virtual Pessoa PesCodigoNavigation { get; set; } = null!;

    [ForeignKey("SerCodigo")]
    [InverseProperty("Venda")]
    public virtual SerServico? SerCodigoNavigation { get; set; }

    [ForeignKey("TpvCodigo")]
    [InverseProperty("Venda")]
    public virtual TipoVendum? TpvCodigoNavigation { get; set; }

    [ForeignKey("UsrUsuarioSistema")]
    [InverseProperty("Venda")]
    public virtual Usuario? UsrUsuarioSistemaNavigation { get; set; }

    [InverseProperty("VdaCodigoNavigation")]
    public virtual ICollection<VendaPagamento> VendaPagamentos { get; set; } = new List<VendaPagamento>();
}
