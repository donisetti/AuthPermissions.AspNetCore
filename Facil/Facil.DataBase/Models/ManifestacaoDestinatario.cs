using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("MANIFESTACAO_DESTINATARIO")]
public partial class ManifestacaoDestinatario
{
    [Key]
    [Column("MD_Codigo")]
    public int MdCodigo { get; set; }

    [Column("MD_Status")]
    public int? MdStatus { get; set; }

    [Column("MD_TpEvento")]
    [StringLength(30)]
    [Unicode(false)]
    public string MdTpEvento { get; set; } = null!;

    [Column("MD_Retorno")]
    [StringLength(100)]
    [Unicode(false)]
    public string MdRetorno { get; set; } = null!;

    [Column("MD_DataProtocolo", TypeName = "smalldatetime")]
    public DateTime MdDataProtocolo { get; set; }

    [Column("DEST_Codigo")]
    public long DestCodigo { get; set; }

    [ForeignKey("DestCodigo")]
    [InverseProperty("ManifestacaoDestinatarios")]
    public virtual NfeDestinada DestCodigoNavigation { get; set; } = null!;
}
