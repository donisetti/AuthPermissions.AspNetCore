using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("NFe_INFNOTAFISCAL")]
public partial class NfeInfnotafiscal
{
    [Key]
    [Column("NFE_Codigo")]
    public int NfeCodigo { get; set; }

    [Column("NFe_NProtocolo")]
    [StringLength(50)]
    public string? NfeNprotocolo { get; set; }

    [Column("NFE_Cupom")]
    public int? NfeCupom { get; set; }

    [Column("NFe_nNF")]
    public int? NfeNNf { get; set; }

    [Column("NFe_DataHoraProtocolo", TypeName = "datetime")]
    public DateTime NfeDataHoraProtocolo { get; set; }

    [Column("NFe_Enviada")]
    [StringLength(50)]
    public string NfeEnviada { get; set; } = null!;

    [Column("NFE_xmlEnvio", TypeName = "text")]
    public string? NfeXmlEnvio { get; set; }

    [Column("NFE_xmlRecebido", TypeName = "text")]
    public string? NfeXmlRecebido { get; set; }

    [Column("NFE_DataHoraCancelamento", TypeName = "datetime")]
    public DateTime? NfeDataHoraCancelamento { get; set; }

    [Column("NFE_UsuarioCancelamento")]
    public short? NfeUsuarioCancelamento { get; set; }

    /// <summary>
    /// A - Aberto E - Enviado C - Cancelado
    /// </summary>
    [Column("NFE_SituacaoEnvio")]
    [StringLength(1)]
    [Unicode(false)]
    public string? NfeSituacaoEnvio { get; set; }

    [Column("VDA_Codigo")]
    public long? VdaCodigo { get; set; }

    [Column("PES_Codigo")]
    public int? PesCodigo { get; set; }

    [Column("NFe_Valor", TypeName = "decimal(15, 2)")]
    public decimal? NfeValor { get; set; }

    [Column("NFe_ChaveAcesso")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NfeChaveAcesso { get; set; }

    [Column("NFe_ApiID")]
    public Guid? NfeApiId { get; set; }

    [Column("OSE_Codigo")]
    public int? OseCodigo { get; set; }

    [Column("EMP_Codigo")]
    public short? EmpCodigo { get; set; }

    [Column("NFe_EnvioCancelada")]
    public bool? NfeEnvioCancelada { get; set; }

    [Column("NFe_EnvioEmail")]
    public bool? NfeEnvioEmail { get; set; }

    [Column("NFe_NRecibo")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NfeNrecibo { get; set; }

    [Column("NFE_SerieNF")]
    public short? NfeSerieNf { get; set; }

    [Column("NFE_xmlCancelado", TypeName = "text")]
    public string? NfeXmlCancelado { get; set; }

    [InverseProperty("NfeCodigoNavigation")]
    public virtual ICollection<NfeNotaCupom> NfeNotaCupoms { get; set; } = new List<NfeNotaCupom>();

    [ForeignKey("PesCodigo")]
    [InverseProperty("NfeInfnotafiscals")]
    public virtual Pessoa? PesCodigoNavigation { get; set; }
}
