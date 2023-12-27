using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("CTEOS_INFNOTAFISCAL")]
public partial class CteosInfnotafiscal
{
    [Key]
    [Column("CTEO_Codigo")]
    public long CteoCodigo { get; set; }

    [Column("EMI_Codigo")]
    public int? EmiCodigo { get; set; }

    [Column("CTEO_Serie")]
    public int? CteoSerie { get; set; }

    [Column("CTEO_nCt")]
    public int? CteoNCt { get; set; }

    [Column("CTEO_DataHoraEmissao", TypeName = "datetime")]
    public DateTime? CteoDataHoraEmissao { get; set; }

    [Column("CTEO_ChaveAcesso")]
    [StringLength(44)]
    [Unicode(false)]
    public string? CteoChaveAcesso { get; set; }

    [Column("CTEO_XmlEnvio", TypeName = "text")]
    public string? CteoXmlEnvio { get; set; }

    [Column("CTEO_XmlRecebido", TypeName = "text")]
    public string? CteoXmlRecebido { get; set; }

    [Column("CTEO_DataHoraCancelamento", TypeName = "datetime")]
    public DateTime? CteoDataHoraCancelamento { get; set; }

    [Column("CTEO_Status")]
    public short? CteoStatus { get; set; }

    [Column("CTEO_Mensagem")]
    [StringLength(500)]
    [Unicode(false)]
    public string? CteoMensagem { get; set; }

    [Column("CTEO_Protocolo")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CteoProtocolo { get; set; }

    [Column("CTEO_XmlCancelamento", TypeName = "text")]
    public string? CteoXmlCancelamento { get; set; }

    [Column("CTEO_EnvioEmail")]
    public bool? CteoEnvioEmail { get; set; }
}
