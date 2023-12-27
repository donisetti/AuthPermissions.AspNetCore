using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PET_FICHA_RECEITUARIO")]
public partial class PetFichaReceituario
{
    [Key]
    [Column("REC_Codigo")]
    public int RecCodigo { get; set; }

    [Column("REC_Data", TypeName = "smalldatetime")]
    public DateTime? RecData { get; set; }

    [Column("REC_Anamnese", TypeName = "text")]
    public string? RecAnamnese { get; set; }

    [Column("REC_Receita")]
    [StringLength(250)]
    [Unicode(false)]
    public string? RecReceita { get; set; }

    [Column("REC_Peso")]
    [StringLength(15)]
    [Unicode(false)]
    public string? RecPeso { get; set; }

    [Column("REC_Diagnostico")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RecDiagnostico { get; set; }

    [Column("REC_DataRetorno", TypeName = "smalldatetime")]
    public DateTime? RecDataRetorno { get; set; }

    [Column("CON_Codigo")]
    public int ConCodigo { get; set; }
}
