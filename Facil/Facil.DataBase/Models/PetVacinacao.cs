using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PET_VACINACAO")]
public partial class PetVacinacao
{
    [Key]
    [Column("VCO_Codigo")]
    public short VcoCodigo { get; set; }

    [Column("VCO_DataAgendamentoVacina", TypeName = "smalldatetime")]
    public DateTime? VcoDataAgendamentoVacina { get; set; }

    [Column("VCO_DataAplicacaoVacina", TypeName = "smalldatetime")]
    public DateTime? VcoDataAplicacaoVacina { get; set; }

    [Column("VAC_Codigo")]
    public short? VacCodigo { get; set; }

    [Column("PAC_Codigo")]
    public int? PacCodigo { get; set; }

    [ForeignKey("PacCodigo")]
    [InverseProperty("PetVacinacaos")]
    public virtual PetPaciente? PacCodigoNavigation { get; set; }

    [ForeignKey("VacCodigo")]
    [InverseProperty("PetVacinacaos")]
    public virtual PetVacina? VacCodigoNavigation { get; set; }
}
