using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PARAMETROS_CTE_naousar")]
public partial class ParametrosCteNaousar
{
    [Key]
    [Column("CTE_Codigo")]
    public short CteCodigo { get; set; }

    [Column("EMP_Codigo")]
    public short? EmpCodigo { get; set; }

    [Column("CTE_Emitir")]
    public bool? CteEmitir { get; set; }

    [Column("CTE_CertificadoNumeroDeSerie")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CteCertificadoNumeroDeSerie { get; set; }

    [Column("CTE_CertificadoDigital")]
    [StringLength(300)]
    [Unicode(false)]
    public string? CteCertificadoDigital { get; set; }

    [Column("CTE_Serie")]
    public short? CteSerie { get; set; }

    [Column("CTE_Modelo")]
    public short? CteModelo { get; set; }

    [Column("CTE_UltimoNumeroCte")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CteUltimoNumeroCte { get; set; }

    [Column("CTE_UfEmitenteWebService")]
    [StringLength(2)]
    [Unicode(false)]
    public string? CteUfEmitenteWebService { get; set; }
}
