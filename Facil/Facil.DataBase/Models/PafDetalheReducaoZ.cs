using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PAF_DETALHE_REDUCAO_Z")]
public partial class PafDetalheReducaoZ
{
    [Key]
    [Column("DTREDZ_Codigo")]
    public int DtredzCodigo { get; set; }

    [Column("IMP_Codigo")]
    public short? ImpCodigo { get; set; }

    [Column("DTREDZ_NumeroUsuario")]
    [StringLength(4)]
    [Unicode(false)]
    public string? DtredzNumeroUsuario { get; set; }

    [Column("DTREDZ_CRZ")]
    [StringLength(6)]
    [Unicode(false)]
    public string? DtredzCrz { get; set; }

    [Column("DTREDZ_TotalizadorParcial")]
    [StringLength(14)]
    [Unicode(false)]
    public string? DtredzTotalizadorParcial { get; set; }

    [Column("DTREDZ_ValorAcumulado")]
    [StringLength(14)]
    [Unicode(false)]
    public string? DtredzValorAcumulado { get; set; }
}
