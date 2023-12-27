using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PET_VACINA")]
public partial class PetVacina
{
    [Key]
    [Column("VAC_Codigo")]
    public short VacCodigo { get; set; }

    [Column("VAC_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string? VacDescricao { get; set; }

    [Column("VAC_Doses")]
    [StringLength(2)]
    [Unicode(false)]
    public string? VacDoses { get; set; }

    [Column("TRV_Codigo")]
    public short? TrvCodigo { get; set; }

    [Column("PRO_Codigo")]
    public int? ProCodigo { get; set; }

    [Column("VAC_ProximaVacina")]
    [StringLength(50)]
    [Unicode(false)]
    public string? VacProximaVacina { get; set; }

    [InverseProperty("VacCodigoNavigation")]
    public virtual ICollection<PetVacinacao> PetVacinacaos { get; set; } = new List<PetVacinacao>();

    [ForeignKey("TrvCodigo")]
    [InverseProperty("PetVacinas")]
    public virtual PetTipoRetornoVacina? TrvCodigoNavigation { get; set; }
}
