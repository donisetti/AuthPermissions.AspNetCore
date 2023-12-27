using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PET_RACA")]
public partial class PetRaca
{
    [Key]
    [Column("RAC_Codigo")]
    public short RacCodigo { get; set; }

    [Column("RAC_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RacDescricao { get; set; }

    [Column("ESP_Codigo")]
    public short EspCodigo { get; set; }

    [ForeignKey("EspCodigo")]
    [InverseProperty("PetRacas")]
    public virtual PetEspecie EspCodigoNavigation { get; set; } = null!;
}
