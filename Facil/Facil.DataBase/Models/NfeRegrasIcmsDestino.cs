using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[PrimaryKey("RicmsCodigoNcm", "RicmsUfDestino")]
[Table("NFe_REGRAS_ICMS_DESTINO")]
public partial class NfeRegrasIcmsDestino
{
    [Key]
    [Column("RICMS_CodigoNCM")]
    [StringLength(8)]
    [Unicode(false)]
    public string RicmsCodigoNcm { get; set; } = null!;

    [Key]
    [Column("RICMS_UF_Destino")]
    [StringLength(2)]
    [Unicode(false)]
    public string RicmsUfDestino { get; set; } = null!;

    [Column("RICMS_VlrPercentual_Contribuinte", TypeName = "decimal(5, 2)")]
    public decimal RicmsVlrPercentualContribuinte { get; set; }

    [Column("RICMS_VlrPercentual_ConsumidorFinal", TypeName = "decimal(5, 2)")]
    public decimal RicmsVlrPercentualConsumidorFinal { get; set; }
}
