using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PESSOA")]
public partial class Pessoa
{
    [Key]
    [Column("ID")]
    public int ID { get; set; }

    [Column("DtCadastro", TypeName = "smalldatetime")]
    public DateTime? DtCadastro { get; set; }

    //[Column("Endereco")]
    //[StringLength(100)]
    //[Unicode(false)]
    //public string? Endereco { get; set; }

    [Column("Complemento")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Complemento { get; set; }

    [Column("Referencia")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Referencia { get; set; }

    [Column("Bairro")]
    [StringLength(80)]
    [Unicode(false)]
    public string? Bairro { get; set; }

    [Column("Municipio")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Municipio { get; set; }

    [Column("Cep")]
    [StringLength(9)]
    [Unicode(false)]
    public string? Cep { get; set; }

    [Column("UF")]
    [StringLength(3)]
    [Unicode(false)]
    public string? UF { get; set; }

    //[Column("PES_Email")]
    //[StringLength(150)]
    //[Unicode(false)]
    //public string? PesEmail { get; set; }

    //[Column("PES_Telefone")]
    //[StringLength(100)]
    //[Unicode(false)]
    //public string? PesTelefone { get; set; }

    //[Column("PES_Celular")]
    //[StringLength(100)]
    //[Unicode(false)]
    //public string? PesCelular { get; set; }

    [Column("Observacao")]
    [StringLength(400)]
    [Unicode(false)]
    public string? Observacao { get; set; }

    [Column("TipoPessoa")]
    [StringLength(1)]
    [Unicode(false)]
    public string TipoPessoa { get; set; } = null!;

    [Column("PES_TipoCadastro")]
    [StringLength(3)]
    [Unicode(false)]
    public string PesTipoCadastro { get; set; } = null!;

    [Column("Bloqueado")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Bloqueado { get; set; }

    [Column("LimiteCredito", TypeName = "decimal(15, 2)")]
    public decimal? LimiteCredito { get; set; }

    [Column("PES_Pct_Desconto", TypeName = "decimal(5, 2)")]
    public decimal? PesPctDesconto { get; set; }

    [Column("PES_Pct_Juros", TypeName = "decimal(5, 2)")]
    public decimal? PesPctJuros { get; set; }

    [Column("PES_TipoCobranca")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PesTipoCobranca { get; set; }

    [Column("PES_CobrancaJuros")]
    public bool? PesCobrancaJuros { get; set; }

    [Column("PES_DiaCobranca")]
    [StringLength(3)]
    [Unicode(false)]
    public string? PesDiaCobranca { get; set; }

    [Column("PES_Dta_UltimaCompra", TypeName = "smalldatetime")]
    public DateTime? PesDtaUltimaCompra { get; set; }

    [Column("PDE_Codigo")]
    public short? PdeCodigo { get; set; }

    [Column("CVN_Codigo")]
    public short? CvnCodigo { get; set; }

    [Column("PER_Codigo")]
    public int? PerCodigo { get; set; }

    [Column("PES_DataExclusao", TypeName = "smalldatetime")]
    public DateTime? PesDataExclusao { get; set; }

    [Column("PES_NumeroEndereco")]
    [StringLength(8)]
    [Unicode(false)]
    public string? PesNumeroEndereco { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastEditDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("PES_UtilizaNumeroOrdem")]
    public bool? PesUtilizaNumeroOrdem { get; set; }

    [Column("USR_Codigo")]
    public short? UsrCodigo { get; set; }

    [Column("pai_IBGE")]
    public int? PaiIbge { get; set; }

    [Column("PES_idEstrangeiro")]
    [StringLength(20)]
    [Unicode(false)]
    public string? PesIdEstrangeiro { get; set; }

    [Column("indIEDest_Codigo")]
    public short? IndIedestCodigo { get; set; }

    [Column("PES_LibVendaCliBloqueado")]
    public short? PesLibVendaCliBloqueado { get; set; }

    [InverseProperty("PesCodigoNavigation")]
    public virtual ICollection<Cheque> Cheques { get; set; } = new List<Cheque>();

    [InverseProperty("PesCodigoNavigation")]
    public virtual ICollection<Consignado> Consignados { get; set; } = new List<Consignado>();

    [InverseProperty("PesCodigoNavigation")]
    public virtual ICollection<ContasReceber> ContasRecebers { get; set; } = new List<ContasReceber>();

    [InverseProperty("PesCodigoNavigation")]
    public virtual ICollection<CopsMovimento> CopsMovimentos { get; set; } = new List<CopsMovimento>();

    [ForeignKey("CvnCodigo")]
    [InverseProperty("Pessoas")]
    public virtual Convenio? CvnCodigoNavigation { get; set; }

    [InverseProperty("PesCodigoNavigation")]
    public virtual ICollection<Devolucao> Devolucaos { get; set; } = new List<Devolucao>();

    [InverseProperty("PesCodigoNavigation")]
    public virtual ICollection<EnderecoEntrega> EnderecoEntregas { get; set; } = new List<EnderecoEntrega>();

    [InverseProperty("PesCodigoNavigation")]
    public virtual ICollection<EntregaEfetuadum> EntregaEfetuada { get; set; } = new List<EntregaEfetuadum>();

    [InverseProperty("PesCodigoNavigation")]
    public virtual Fisica? Fisica { get; set; }

    [ForeignKey("IndIedestCodigo")]
    [InverseProperty("Pessoas")]
    public virtual NfeTipoContribuinte? IndIedestCodigoNavigation { get; set; }

    [InverseProperty("PesCodigoNavigation")]
    public virtual Juridica? Juridica { get; set; }

    [InverseProperty("PesCodigoNavigation")]
    public virtual ICollection<NfeInfnotafiscal> NfeInfnotafiscals { get; set; } = new List<NfeInfnotafiscal>();

    [InverseProperty("PesCodigoNavigation")]
    public virtual ICollection<Orcamento> Orcamentos { get; set; } = new List<Orcamento>();

    [InverseProperty("PesCodigoNavigation")]
    public virtual ICollection<PessoaClassificacao> PessoaClassificacaos { get; set; } = new List<PessoaClassificacao>();

    [InverseProperty("PesCodigoNavigation")]
    public virtual ICollection<PetAgendum> PetAgenda { get; set; } = new List<PetAgendum>();

    [InverseProperty("PesCodigoNavigation")]
    public virtual ICollection<SerCompra> SerCompras { get; set; } = new List<SerCompra>();

    [InverseProperty("PesCodigoNavigation")]
    public virtual ICollection<SerEquipamento> SerEquipamentos { get; set; } = new List<SerEquipamento>();

    [InverseProperty("PesCodigoNavigation")]
    public virtual ICollection<SerServico> SerServicos { get; set; } = new List<SerServico>();

    [InverseProperty("PesCodigoNavigation")]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();

    [InverseProperty("PesCodigoNavigation")]
    public virtual ICollection<Vendum> Venda { get; set; } = new List<Vendum>();
}
