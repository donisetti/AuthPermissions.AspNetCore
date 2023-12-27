using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[PrimaryKey("SticmsCodigoSituacaoTributaria", "SticmsCodigo")]
[Table("NFe_ST_ICMS")]
public partial class NfeStIcm
{
    [Key]
    [Column("STICMS_CodigoSituacaoTributaria")]
    public short SticmsCodigoSituacaoTributaria { get; set; }

    [Key]
    [Column("STICMS_Codigo")]
    [StringLength(3)]
    [Unicode(false)]
    public string SticmsCodigo { get; set; } = null!;

    [Column("STICMS_Descricao")]
    [StringLength(150)]
    [Unicode(false)]
    public string SticmsDescricao { get; set; } = null!;
}
