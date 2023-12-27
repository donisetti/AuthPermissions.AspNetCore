using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("EMITENTE")]
public partial class Emitente
{
    [Key]
    [Column("EMI_Codigo")]
    public short EmiCodigo { get; set; }

    [Column("EMI_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string EmiDescricao { get; set; } = null!;

    [Column("EMI_Cnpj")]
    [StringLength(15)]
    [Unicode(false)]
    public string EmiCnpj { get; set; } = null!;

    [Column("EMI_Endereco")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EmiEndereco { get; set; }

    [Column("EMI_Cidade")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmiCidade { get; set; }

    [Column("EMI_Bairro")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmiBairro { get; set; }

    [Column("EMI_UF")]
    [StringLength(3)]
    [Unicode(false)]
    public string? EmiUf { get; set; }

    [Column("EMI_CEP")]
    [StringLength(9)]
    [Unicode(false)]
    public string? EmiCep { get; set; }

    [Column("EMI_Razao")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmiRazao { get; set; }

    [Column("EMI_Fone")]
    [StringLength(15)]
    [Unicode(false)]
    public string? EmiFone { get; set; }

    [Column("EMI_Fax")]
    [StringLength(15)]
    [Unicode(false)]
    public string? EmiFax { get; set; }

    [Column("EMI_Numero")]
    [StringLength(5)]
    [Unicode(false)]
    public string? EmiNumero { get; set; }

    [Column("EMI_Complemento")]
    [StringLength(22)]
    [Unicode(false)]
    public string? EmiComplemento { get; set; }

    [Column("EMI_Contato")]
    [StringLength(18)]
    [Unicode(false)]
    public string? EmiContato { get; set; }

    [Column("EMI_InscricaoEstadual")]
    [StringLength(20)]
    [Unicode(false)]
    public string? EmiInscricaoEstadual { get; set; }

    [Column("EMI_RegimeTributario")]
    public short? EmiRegimeTributario { get; set; }

    [Column("EMI_AliqICMSSN", TypeName = "decimal(10, 2)")]
    public decimal? EmiAliqIcmssn { get; set; }

    [Column("EMI_Aliquota_Pis", TypeName = "decimal(10, 2)")]
    public decimal? EmiAliquotaPis { get; set; }

    [Column("EMI_Aliquota_Cofins", TypeName = "decimal(10, 2)")]
    public decimal? EmiAliquotaCofins { get; set; }

    [Column("EMI_DadosAdicionais")]
    [StringLength(500)]
    [Unicode(false)]
    public string? EmiDadosAdicionais { get; set; }

    [Column("EMI_LocalLogoMarca")]
    [StringLength(150)]
    [Unicode(false)]
    public string? EmiLocalLogoMarca { get; set; }

    [Column("EMI_UltimoNumCte")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmiUltimoNumCte { get; set; }

    [Column("EMI_SerieCTe")]
    public short? EmiSerieCte { get; set; }

    [Column("EMI_CertificadoDigital")]
    [StringLength(300)]
    [Unicode(false)]
    public string? EmiCertificadoDigital { get; set; }

    [Column("EMI_SenhaSmtp")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmiSenhaSmtp { get; set; }

    [Column("EMI_EmailSmtp")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EmiEmailSmtp { get; set; }

    [Column("EMI_MensagemPadraoSmtp")]
    [StringLength(150)]
    [Unicode(false)]
    public string? EmiMensagemPadraoSmtp { get; set; }

    [Column("EMI_UsuarioSmtp")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmiUsuarioSmtp { get; set; }

    [Column("EMI_NomeServidorSmtp")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EmiNomeServidorSmtp { get; set; }

    [Column("EMI_UtilizarSSL")]
    public bool? EmiUtilizarSsl { get; set; }

    [Column("EMI_NumeroPortaSmtp")]
    public short? EmiNumeroPortaSmtp { get; set; }

    [Column("EMI_TipoCertificado")]
    [StringLength(3)]
    [Unicode(false)]
    public string? EmiTipoCertificado { get; set; }

    [Column("EMI_EmailContador")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EmiEmailContador { get; set; }

    [Column("EMI_NomeContador")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmiNomeContador { get; set; }

    [Column("EMI_CpfContador")]
    [StringLength(15)]
    [Unicode(false)]
    public string? EmiCpfContador { get; set; }

    [Column("EMI_CrcContador")]
    [StringLength(20)]
    [Unicode(false)]
    public string? EmiCrcContador { get; set; }

    [Column("EMI_ModeloCTe")]
    [StringLength(3)]
    [Unicode(false)]
    public string? EmiModeloCte { get; set; }

    [Column("EMI_WebService_UF_EmitenteCTe")]
    [StringLength(2)]
    [Unicode(false)]
    public string? EmiWebServiceUfEmitenteCte { get; set; }

    [Column("EMI_VersaoSchemaCTe")]
    [StringLength(4)]
    [Unicode(false)]
    public string? EmiVersaoSchemaCte { get; set; }

    [Column("EMI_TipoAmbienteCTe")]
    public short? EmiTipoAmbienteCte { get; set; }

    [Column("EMI_TipoEmissaoCTe")]
    public short? EmiTipoEmissaoCte { get; set; }

    [Column("EMI_MensagemComplementarNFCe")]
    [StringLength(250)]
    [Unicode(false)]
    public string? EmiMensagemComplementarNfce { get; set; }

    [Column("EMI_ApiClienteID")]
    public Guid? EmiApiClienteId { get; set; }

    [Column("EMI_ApiContadorID")]
    public Guid? EmiApiContadorId { get; set; }

    [Column("EMI_EmailEmpresa")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmiEmailEmpresa { get; set; }

    [Column("EMI_DLimite", TypeName = "smalldatetime")]
    public DateTime? EmiDlimite { get; set; }

    [Column("EMI_DataCadastroApi", TypeName = "smalldatetime")]
    public DateTime? EmiDataCadastroApi { get; set; }

    [Column("EMI_LicencaDLL")]
    [StringLength(150)]
    [Unicode(false)]
    public string? EmiLicencaDll { get; set; }

    [Column("EMI_TAF")]
    [StringLength(12)]
    [Unicode(false)]
    public string? EmiTaf { get; set; }

    [Column("EMI_NroRegEstadual")]
    [StringLength(25)]
    [Unicode(false)]
    public string? EmiNroRegEstadual { get; set; }

    [Column("EMI_ApiAtivo")]
    public bool? EmiApiAtivo { get; set; }

    [Column("EMI_ApiHabilitado")]
    public bool? EmiApiHabilitado { get; set; }

    [InverseProperty("EmiCodigoNavigation")]
    public virtual ICollection<CteEmitenteModal> CteEmitenteModals { get; set; } = new List<CteEmitenteModal>();

    [InverseProperty("EmiCodigoNavigation")]
    public virtual ICollection<CteModal> CteModals { get; set; } = new List<CteModal>();
}
