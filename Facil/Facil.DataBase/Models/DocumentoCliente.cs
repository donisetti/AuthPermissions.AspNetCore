using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("DOCUMENTO_CLIENTES")]
public partial class DocumentoCliente
{
    [Key]
    [Column("DCLI_Codigo")]
    public int DcliCodigo { get; set; }

    [Column("DCLI_Numero_Documento")]
    [StringLength(20)]
    [Unicode(false)]
    public string DcliNumeroDocumento { get; set; } = null!;

    [Column("DCLI_UFEmissaoDocumento")]
    [StringLength(3)]
    [Unicode(false)]
    public string DcliUfemissaoDocumento { get; set; } = null!;

    [Column("PCLI_Codigo")]
    public int PcliCodigo { get; set; }

    [Column("TDO_Codigo")]
    public short TdoCodigo { get; set; }

    [Column("OEX_Codigo")]
    public short OexCodigo { get; set; }

    [ForeignKey("OexCodigo")]
    [InverseProperty("DocumentoClientes")]
    public virtual OrgaoExpedidor OexCodigoNavigation { get; set; } = null!;

    [ForeignKey("PcliCodigo")]
    [InverseProperty("DocumentoClientes")]
    public virtual PsicoCliente PcliCodigoNavigation { get; set; } = null!;

    [ForeignKey("TdoCodigo")]
    [InverseProperty("DocumentoClientes")]
    public virtual TipoDocumento TdoCodigoNavigation { get; set; } = null!;
}
