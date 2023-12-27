using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("IMPRESSAO_ETIQUETAS_TEMP")]
public partial class ImpressaoEtiquetasTemp
{
    [Key]
    [Column("ETT_Codigo")]
    public short EttCodigo { get; set; }

    [Column("ETT_DataEntrada", TypeName = "smalldatetime")]
    public DateTime? EttDataEntrada { get; set; }

    [Column("ETT_Quantidade", TypeName = "decimal(10, 3)")]
    public decimal? EttQuantidade { get; set; }

    [Column("PRO_Codigo")]
    public long? ProCodigo { get; set; }

    [Column("EMP_Codigo")]
    public short? EmpCodigo { get; set; }
}
