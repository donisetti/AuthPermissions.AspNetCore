using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PET_AGENDA")]
public partial class PetAgendum
{
    [Key]
    [Column("AGE_Codigo")]
    public int AgeCodigo { get; set; }

    [Column("AGE_DataLancamento", TypeName = "smalldatetime")]
    public DateTime? AgeDataLancamento { get; set; }

    [Column("AGE_DataExecucao", TypeName = "smalldatetime")]
    public DateTime? AgeDataExecucao { get; set; }

    [Column("AGE_Observacao")]
    [StringLength(150)]
    [Unicode(false)]
    public string? AgeObservacao { get; set; }

    [Column("PRO_Codigo")]
    public int? ProCodigo { get; set; }

    [Column("PES_Codigo")]
    public int? PesCodigo { get; set; }

    [Column("PAC_Codigo")]
    public int? PacCodigo { get; set; }

    [ForeignKey("PacCodigo")]
    [InverseProperty("PetAgenda")]
    public virtual PetPaciente? PacCodigoNavigation { get; set; }

    [ForeignKey("PesCodigo")]
    [InverseProperty("PetAgenda")]
    public virtual Pessoa? PesCodigoNavigation { get; set; }

    [ForeignKey("ProCodigo")]
    [InverseProperty("PetAgenda")]
    public virtual Produto? ProCodigoNavigation { get; set; }
}
