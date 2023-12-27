using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PET_CONSULTA")]
public partial class PetConsultum
{
    [Key]
    [Column("CON_Codigo")]
    public int ConCodigo { get; set; }

    [Column("CON_DataMovimento", TypeName = "smalldatetime")]
    public DateTime? ConDataMovimento { get; set; }

    [Column("CON_DataFechamento", TypeName = "smalldatetime")]
    public DateTime? ConDataFechamento { get; set; }

    [Column("CON_Observacao")]
    [StringLength(150)]
    [Unicode(false)]
    public string? ConObservacao { get; set; }

    [Column("MED_Codigo")]
    public int MedCodigo { get; set; }

    [Column("PAC_Codigo")]
    public int PacCodigo { get; set; }

    [Column("CON_DataExclusao", TypeName = "smalldatetime")]
    public DateTime? ConDataExclusao { get; set; }

    [ForeignKey("PacCodigo")]
    [InverseProperty("PetConsulta")]
    public virtual PetPaciente PacCodigoNavigation { get; set; } = null!;
}
