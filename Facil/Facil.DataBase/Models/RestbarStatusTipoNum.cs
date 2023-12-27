using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Keyless]
[Table("RESTBAR_STATUS_TIPO_NUM")]
public partial class RestbarStatusTipoNum
{
    [Column("RBT_CODIGO")]
    public short? RbtCodigo { get; set; }

    [Column("STAT_NUMERACAO")]
    public short? StatNumeracao { get; set; }

    [Column("STAT_STATUS")]
    public bool? StatStatus { get; set; }

    [Column("STAT_TEMPO")]
    [StringLength(10)]
    [Unicode(false)]
    public string? StatTempo { get; set; }

    [Column("STAT_VALOR_TOTAL", TypeName = "decimal(15, 2)")]
    public decimal? StatValorTotal { get; set; }
}
