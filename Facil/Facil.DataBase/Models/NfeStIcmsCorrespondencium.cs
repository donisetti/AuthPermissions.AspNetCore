using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[PrimaryKey("SticmsNfFornecedor", "SticmsSaida")]
[Table("NFe_ST_ICMS_CORRESPONDENCIA")]
public partial class NfeStIcmsCorrespondencium
{
    [Key]
    [Column("STICMS_NF_Fornecedor")]
    [StringLength(3)]
    [Unicode(false)]
    public string SticmsNfFornecedor { get; set; } = null!;

    [Key]
    [Column("STICMS_Saida")]
    [StringLength(3)]
    [Unicode(false)]
    public string SticmsSaida { get; set; } = null!;

    [Column("STICMS_CodigoSituacaoTributaria")]
    public short SticmsCodigoSituacaoTributaria { get; set; }
}
