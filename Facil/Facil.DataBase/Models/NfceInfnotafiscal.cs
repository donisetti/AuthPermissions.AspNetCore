using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("NFCe_INFNOTAFISCAL")]
public partial class NfceInfnotafiscal
{
    [Key]
    [Column("NFCE_Codigo")]
    public long NfceCodigo { get; set; }

    [Column("VDA_Codigo")]
    public long? VdaCodigo { get; set; }

    [Column("NFCE_Serie")]
    public int? NfceSerie { get; set; }

    [Column("NFCE_nNF")]
    public int? NfceNNf { get; set; }

    [Column("NFCE_DataHoraEmissao", TypeName = "datetime")]
    public DateTime NfceDataHoraEmissao { get; set; }

    [Column("NFCE_DataHoraAutorizacao", TypeName = "datetime")]
    public DateTime? NfceDataHoraAutorizacao { get; set; }

    [Column("NFe_ChaveAcesso")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NfeChaveAcesso { get; set; }

    [Column("NFCE_xmlEnvio", TypeName = "text")]
    public string? NfceXmlEnvio { get; set; }

    [Column("NFCE_xmlRecebido", TypeName = "text")]
    public string? NfceXmlRecebido { get; set; }

    [Column("NFCE_DataHoraCancelamento", TypeName = "datetime")]
    public DateTime? NfceDataHoraCancelamento { get; set; }

    [Column("NFCE_UsuarioCancelamento")]
    public short? NfceUsuarioCancelamento { get; set; }

    [Column("NFCE_Status")]
    public short? NfceStatus { get; set; }

    [Column("NFCE_Mensagem", TypeName = "text")]
    public string? NfceMensagem { get; set; }

    [Column("NFCe_Protocolo")]
    [StringLength(20)]
    [Unicode(false)]
    public string? NfceProtocolo { get; set; }

    [Column("NFCe_xmlCancelamento", TypeName = "text")]
    public string? NfceXmlCancelamento { get; set; }

    [Column("NFCe_vNF", TypeName = "decimal(15, 2)")]
    public decimal? NfceVNf { get; set; }

    [Column("NFCe_ApiID")]
    public Guid? NfceApiId { get; set; }

    [Column("EMP_Codigo")]
    public short? EmpCodigo { get; set; }

    [Column("NFCe_EnvioEmail")]
    public bool? NfceEnvioEmail { get; set; }

    [Column("NFCe_EnvioCancelada")]
    public bool? NfceEnvioCancelada { get; set; }

    [InverseProperty("NfceCodigoNavigation")]
    public virtual ICollection<NfceContingencium> NfceContingencia { get; set; } = new List<NfceContingencium>();
}
