using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("ORGAO_EXPEDIDOR")]
public partial class OrgaoExpedidor
{
    [Key]
    [Column("OEX_Codigo")]
    public short OexCodigo { get; set; }

    [Column("OEX_Sigla")]
    [StringLength(10)]
    [Unicode(false)]
    public string OexSigla { get; set; } = null!;

    [Column("OEX_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string OexDescricao { get; set; } = null!;

    [InverseProperty("OexCodigoNavigation")]
    public virtual ICollection<DocumentoCliente> DocumentoClientes { get; set; } = new List<DocumentoCliente>();
}
