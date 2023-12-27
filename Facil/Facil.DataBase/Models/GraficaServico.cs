using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("GRAFICA_SERVICOS")]
public partial class GraficaServico
{
    [Key]
    [Column("GRAFS_Codigo")]
    public int GrafsCodigo { get; set; }

    [Column("GRAFS_DataMovimento", TypeName = "datetime")]
    public DateTime? GrafsDataMovimento { get; set; }

    [Column("GRAFS_DataEntrega", TypeName = "datetime")]
    public DateTime? GrafsDataEntrega { get; set; }

    [Column("GRAFS_DataExclusao", TypeName = "datetime")]
    public DateTime? GrafsDataExclusao { get; set; }

    [Column("GRAFS_Observacao")]
    [StringLength(200)]
    [Unicode(false)]
    public string? GrafsObservacao { get; set; }

    [Column("PES_Codigo")]
    public int? PesCodigo { get; set; }

    [Column("VDA_Codigo")]
    public long? VdaCodigo { get; set; }
}
