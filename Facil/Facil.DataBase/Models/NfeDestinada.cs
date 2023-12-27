using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("NFe_DESTINADAS")]
public partial class NfeDestinada
{
    [Key]
    [Column("DEST_Codigo")]
    public long DestCodigo { get; set; }

    [Column("DEST_NSU")]
    public int DestNsu { get; set; }

    [Column("DEST_Emitente")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DestEmitente { get; set; }

    [Column("DEST_CnpjEmitente")]
    [StringLength(15)]
    [Unicode(false)]
    public string? DestCnpjEmitente { get; set; }

    [Column("DEST_DataEmissao", TypeName = "datetime")]
    public DateTime? DestDataEmissao { get; set; }

    [Column("DEST_ChNFe")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DestChNfe { get; set; }

    [Column("DEST_VlrNFe", TypeName = "decimal(15, 2)")]
    public decimal? DestVlrNfe { get; set; }

    [Column("DEST_XML", TypeName = "text")]
    public string? DestXml { get; set; }

    [Column("DEST_Status")]
    [StringLength(200)]
    [Unicode(false)]
    public string? DestStatus { get; set; }

    [Column("DEST_CodigoStatus")]
    public int? DestCodigoStatus { get; set; }

    [Column("EMP_Codigo")]
    public short? EmpCodigo { get; set; }

    [Column("DEST_nNF")]
    public int? DestNNf { get; set; }

    [Column("DEST_Evento")]
    [StringLength(30)]
    [Unicode(false)]
    public string? DestEvento { get; set; }

    [Column("DEST_Serie")]
    public int? DestSerie { get; set; }

    [Column("ENT_Codigo")]
    public int? EntCodigo { get; set; }

    [Column("DEST_cSitNFe")]
    public short? DestCSitNfe { get; set; }

    [InverseProperty("DestCodigoNavigation")]
    public virtual ICollection<ManifestacaoDestinatario> ManifestacaoDestinatarios { get; set; } = new List<ManifestacaoDestinatario>();
}
