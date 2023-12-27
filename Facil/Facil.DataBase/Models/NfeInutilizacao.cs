using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("NFe_INUTILIZACAO")]
public partial class NfeInutilizacao
{
    [Key]
    [Column("INU_Codigo")]
    public long InuCodigo { get; set; }

    [Column("INU_Serie")]
    public int InuSerie { get; set; }

    [Column("INU_nNfIni")]
    public int InuNNfIni { get; set; }

    [Column("INU_nNfFim")]
    public int InuNNfFim { get; set; }

    [Column("INU_Justificativa", TypeName = "text")]
    public string InuJustificativa { get; set; } = null!;

    [Column("INU_DataHoraRecbto", TypeName = "datetime")]
    public DateTime InuDataHoraRecbto { get; set; }

    [Column("INU_Status")]
    public short InuStatus { get; set; }

    [Column("INU_Mensagem", TypeName = "text")]
    public string InuMensagem { get; set; } = null!;

    [Column("INU_Protocolo")]
    [StringLength(20)]
    [Unicode(false)]
    public string InuProtocolo { get; set; } = null!;

    [Column("USR_Codigo")]
    public short? UsrCodigo { get; set; }

    [Column("INU_Xml", TypeName = "text")]
    public string? InuXml { get; set; }

    [ForeignKey("UsrCodigo")]
    [InverseProperty("NfeInutilizacaos")]
    public virtual Usuario? UsrCodigoNavigation { get; set; }
}
