using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("GRAFICA_VENDA_SERVICOS")]
public partial class GraficaVendaServico
{
    [Key]
    [Column("GRAFVS_Codigo")]
    public int GrafvsCodigo { get; set; }

    [Column("GRAFS_Codigo")]
    public int? GrafsCodigo { get; set; }

    [Column("GRAFSI_Codigo")]
    public short? GrafsiCodigo { get; set; }

    [Column("VDA_Codigo")]
    public long? VdaCodigo { get; set; }
}
