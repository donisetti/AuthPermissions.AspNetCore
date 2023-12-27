using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("EMPRESAS_GRUPO")]
public partial class EmpresasGrupo
{
    [Key]
    [Column("EMP_Codigo")]
    public short EmpCodigo { get; set; }

    [Column("EMP_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string EmpDescricao { get; set; } = null!;

    [Column("EMP_Cnpj")]
    [StringLength(15)]
    [Unicode(false)]
    public string EmpCnpj { get; set; } = null!;

    [Column("EMP_Endereco")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EmpEndereco { get; set; }

    [Column("EMP_Cidade")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmpCidade { get; set; }

    [Column("EMP_Bairro")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmpBairro { get; set; }

    [Column("EMP_UF")]
    [StringLength(3)]
    [Unicode(false)]
    public string? EmpUf { get; set; }

    [Column("EMP_CEP")]
    [StringLength(9)]
    [Unicode(false)]
    public string? EmpCep { get; set; }

    [Column("EMP_Razao")]
    [StringLength(60)]
    [Unicode(false)]
    public string? EmpRazao { get; set; }

    [Column("EMP_Fone")]
    [StringLength(15)]
    [Unicode(false)]
    public string? EmpFone { get; set; }

    [Column("EMP_Fax")]
    [StringLength(15)]
    [Unicode(false)]
    public string? EmpFax { get; set; }

    [Column("EMP_SaldoContaCaixa", TypeName = "decimal(15, 2)")]
    public decimal? EmpSaldoContaCaixa { get; set; }

    [Column("EMP_Numero")]
    [StringLength(5)]
    [Unicode(false)]
    public string? EmpNumero { get; set; }

    [Column("EMP_Complemento")]
    [StringLength(22)]
    [Unicode(false)]
    public string? EmpComplemento { get; set; }

    [Column("EMP_Contato")]
    [StringLength(18)]
    [Unicode(false)]
    public string? EmpContato { get; set; }

    [Column("EMP_InscricaoEstadual")]
    [StringLength(20)]
    [Unicode(false)]
    public string? EmpInscricaoEstadual { get; set; }

    [Column("EMP_RegimeTributario")]
    public short? EmpRegimeTributario { get; set; }

    [Column("EMP_DadosAdicionais")]
    [StringLength(500)]
    [Unicode(false)]
    public string? EmpDadosAdicionais { get; set; }

    [Column("EMP_SenhaProxy")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmpSenhaProxy { get; set; }

    [Column("EMP_UsuarioProxy")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmpUsuarioProxy { get; set; }

    [Column("EMP_VersaoSchema")]
    [StringLength(4)]
    [Unicode(false)]
    public string? EmpVersaoSchema { get; set; }

    [Column("EMP_ModeloNF")]
    [StringLength(3)]
    [Unicode(false)]
    public string? EmpModeloNf { get; set; }

    [Column("EMP_TipoAmbiente")]
    public short? EmpTipoAmbiente { get; set; }

    [Column("EMP_CertificadoDigital")]
    [StringLength(300)]
    [Unicode(false)]
    public string? EmpCertificadoDigital { get; set; }

    [Column("EMP_UsuarioSmtp")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmpUsuarioSmtp { get; set; }

    [Column("EMP_LicencaDLL")]
    [StringLength(150)]
    [Unicode(false)]
    public string? EmpLicencaDll { get; set; }

    [Column("EMP_WebService_UF_Emitente")]
    [StringLength(2)]
    [Unicode(false)]
    public string? EmpWebServiceUfEmitente { get; set; }

    [Column("EMP_TipoServico")]
    public short? EmpTipoServico { get; set; }

    [Column("EMP_LocalLogoMarca")]
    [StringLength(150)]
    [Unicode(false)]
    public string? EmpLocalLogoMarca { get; set; }

    [Column("EMP_NomeServidorSmtp")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EmpNomeServidorSmtp { get; set; }

    [Column("EMP_UtilizarSSL")]
    public bool? EmpUtilizarSsl { get; set; }

    [Column("EMP_SenhaSmtp")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmpSenhaSmtp { get; set; }

    [Column("EMP_EmailSmtp")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EmpEmailSmtp { get; set; }

    [Column("EMP_MensagemPadraoSmtp")]
    [StringLength(150)]
    [Unicode(false)]
    public string? EmpMensagemPadraoSmtp { get; set; }

    [Column("EMP_EnviarDanfe")]
    public bool? EmpEnviarDanfe { get; set; }

    [Column("EMP_CodigoCertificadora")]
    public short? EmpCodigoCertificadora { get; set; }

    [Column("EMP_NumeroPortaSmtp")]
    public short? EmpNumeroPortaSmtp { get; set; }

    [Column("EMP_TipoCertificado")]
    [StringLength(3)]
    [Unicode(false)]
    public string? EmpTipoCertificado { get; set; }

    [Column("EMP_Proxy")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EmpProxy { get; set; }

    [Column("EMP_IM")]
    [StringLength(30)]
    [Unicode(false)]
    public string? EmpIm { get; set; }

    [Column("EMP_CNAE")]
    [StringLength(10)]
    [Unicode(false)]
    public string? EmpCnae { get; set; }

    /// <summary>
    /// Número da última nota fiscal eletrônica emitida
    /// </summary>
    [Column("EMP_UltimaNota")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmpUltimaNota { get; set; }

    [Column("EMP_SerieNF")]
    public short? EmpSerieNf { get; set; }

    /// <summary>
    /// Alíquota ICMS Simples Nacional
    /// </summary>
    [Column("EMP_AliqICMSSN", TypeName = "decimal(5, 2)")]
    public decimal? EmpAliqIcmssn { get; set; }

    [Column("EMP_EmailContador")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EmpEmailContador { get; set; }

    [Column("EMP_NomeContador")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmpNomeContador { get; set; }

    [Column("EMP_CpfContador")]
    [StringLength(15)]
    [Unicode(false)]
    public string? EmpCpfContador { get; set; }

    [Column("EMP_CrcContador")]
    [StringLength(20)]
    [Unicode(false)]
    public string? EmpCrcContador { get; set; }

    [Column("EMP_Aliquota_Pis", TypeName = "decimal(10, 2)")]
    public decimal? EmpAliquotaPis { get; set; }

    [Column("EMP_Aliquota_Cofins", TypeName = "decimal(10, 2)")]
    public decimal? EmpAliquotaCofins { get; set; }

    [Column("EMP_Atividade")]
    public short? EmpAtividade { get; set; }

    [Column("EMP_Perfil")]
    [StringLength(1)]
    [Unicode(false)]
    public string? EmpPerfil { get; set; }

    [Column("EMP_TipoEmissao")]
    [StringLength(1)]
    [Unicode(false)]
    public string? EmpTipoEmissao { get; set; }

    [Column("EMP_ModeloNFCe")]
    [StringLength(3)]
    [Unicode(false)]
    public string? EmpModeloNfce { get; set; }

    [Column("EMP_SerieNFCe")]
    public short? EmpSerieNfce { get; set; }

    [Column("EMP_UltimaNotaNFCe")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmpUltimaNotaNfce { get; set; }

    [Column("EMP_WebService_UF_EmitenteNFCe")]
    [StringLength(2)]
    [Unicode(false)]
    public string? EmpWebServiceUfEmitenteNfce { get; set; }

    [Column("EMP_VersaoSchemaNFCe")]
    [StringLength(4)]
    [Unicode(false)]
    public string? EmpVersaoSchemaNfce { get; set; }

    [Column("EMP_TipoAmbienteNFCe")]
    public short? EmpTipoAmbienteNfce { get; set; }

    [Column("EMP_TipoEmissaoNFCe")]
    public short? EmpTipoEmissaoNfce { get; set; }

    [Column("EMP_IdToken")]
    [StringLength(6)]
    [Unicode(false)]
    public string? EmpIdToken { get; set; }

    [Column("EMP_CSC")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmpCsc { get; set; }

    [Column("EMP_MensagemComplementarNFCe")]
    [StringLength(250)]
    [Unicode(false)]
    public string? EmpMensagemComplementarNfce { get; set; }

    [Column("EMP_ApiClienteID")]
    public Guid? EmpApiClienteId { get; set; }

    [Column("EMP_ApiContadorID")]
    public Guid? EmpApiContadorId { get; set; }

    [Column("EMP_DataReinicioDocFiscal")]
    [StringLength(20)]
    [Unicode(false)]
    public string? EmpDataReinicioDocFiscal { get; set; }

    [Column("EMP_ReiniciarDocFiscal")]
    public bool? EmpReiniciarDocFiscal { get; set; }

    [Column("EMP_EmailEmpresa")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmpEmailEmpresa { get; set; }

    [Column("EMP_DLimite", TypeName = "datetime")]
    public DateTime? EmpDlimite { get; set; }

    [Column("EMP_DataCadastroApi", TypeName = "smalldatetime")]
    public DateTime? EmpDataCadastroApi { get; set; }

    [Column("EMP_AtualizarVersao")]
    public bool? EmpAtualizarVersao { get; set; }

    [Column("EMP_AtualizarTabelaNcm")]
    public bool? EmpAtualizarTabelaNcm { get; set; }

    [Column("EMP_ProtocoloSeguranca")]
    public short? EmpProtocoloSeguranca { get; set; }

    [Column("EMP_ApiAtivo")]
    public bool? EmpApiAtivo { get; set; }

    [Column("EMP_ApiHabilitado")]
    public bool? EmpApiHabilitado { get; set; }

    [Column("EMP_TipoAmbienteExecSistema")]
    public short? EmpTipoAmbienteExecSistema { get; set; }

    [Column("EMP_DataCiencia", TypeName = "smalldatetime")]
    public DateTime? EmpDataCiencia { get; set; }

    [Column("EMP_DataNotifica1", TypeName = "smalldatetime")]
    public DateTime? EmpDataNotifica1 { get; set; }

    [Column("EMP_DataNotifica2", TypeName = "smalldatetime")]
    public DateTime? EmpDataNotifica2 { get; set; }

    [Column("EMP_NotificaMsg")]
    [StringLength(150)]
    [Unicode(false)]
    public string? EmpNotificaMsg { get; set; }

    [Column("EMP_CNPJContador")]
    [StringLength(15)]
    [Unicode(false)]
    public string? EmpCnpjcontador { get; set; }

    [Column("EMP_TipoAutXML")]
    [StringLength(4)]
    [Unicode(false)]
    public string? EmpTipoAutXml { get; set; }

    [Column("EMP_UsaAutXML")]
    public bool? EmpUsaAutXml { get; set; }

    [Column("EMP_LogoNFCe")]
    public byte[]? EmpLogoNfce { get; set; }

    [Column("EMP_ImagemLogo")]
    public byte[]? EmpImagemLogo { get; set; }

    [Column("EMP_UsaCertificadoBase64")]
    public bool? EmpUsaCertificadoBase64 { get; set; }

    [InverseProperty("EmpCodigoNavigation")]
    public virtual ICollection<Devolucao> Devolucaos { get; set; } = new List<Devolucao>();

    [InverseProperty("EmpCodigoNavigation")]
    public virtual ParametrosNfce? ParametrosNfce { get; set; }

    [InverseProperty("EmpCodigoNavigation")]
    public virtual ICollection<ParametrosNfse> ParametrosNfses { get; set; } = new List<ParametrosNfse>();
}
