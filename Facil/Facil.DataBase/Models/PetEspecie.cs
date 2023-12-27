using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PET_ESPECIE")]
public partial class PetEspecie
{
    [Key]
    [Column("ESP_Codigo")]
    public short EspCodigo { get; set; }

    [Column("ESP_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EspDescricao { get; set; }

    [InverseProperty("EspCodigoNavigation")]
    public virtual ICollection<PetRaca> PetRacas { get; set; } = new List<PetRaca>();
}
