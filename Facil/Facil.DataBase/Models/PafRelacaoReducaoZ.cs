using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PAF_RELACAO_REDUCAO_Z")]
public partial class PafRelacaoReducaoZ
{
    [Key]
    [Column("REDZ_Codigo")]
    public int RedzCodigo { get; set; }

    [Column("IMP_Codigo")]
    public short? ImpCodigo { get; set; }

    [Column("REDZ_NumeroUsuario")]
    [StringLength(4)]
    [Unicode(false)]
    public string? RedzNumeroUsuario { get; set; }

    [Column("REDZ_CRZ")]
    [StringLength(6)]
    [Unicode(false)]
    public string? RedzCrz { get; set; }

    [Column("REDZ_COO")]
    [StringLength(6)]
    [Unicode(false)]
    public string? RedzCoo { get; set; }

    [Column("REDZ_CRO")]
    [StringLength(6)]
    [Unicode(false)]
    public string? RedzCro { get; set; }

    [Column("REDZ_DataMovimento")]
    [StringLength(8)]
    [Unicode(false)]
    public string? RedzDataMovimento { get; set; }

    [Column("REDZ_DataEmissao")]
    [StringLength(8)]
    [Unicode(false)]
    public string? RedzDataEmissao { get; set; }

    [Column("REDZ_HoraEmissao")]
    [StringLength(8)]
    [Unicode(false)]
    public string? RedzHoraEmissao { get; set; }

    [Column("REDZ_VendaBruta")]
    [StringLength(18)]
    [Unicode(false)]
    public string? RedzVendaBruta { get; set; }

    [Column("REDZ_ParametroECF")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RedzParametroEcf { get; set; }

    [Column("REDZ_ValorTotalizadorGeral")]
    [StringLength(18)]
    [Unicode(false)]
    public string? RedzValorTotalizadorGeral { get; set; }
}
