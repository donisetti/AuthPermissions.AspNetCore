using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PET_TIPO_RETORNO_VACINA")]
public partial class PetTipoRetornoVacina
{
    [Key]
    [Column("TRV_Codigo")]
    public short TrvCodigo { get; set; }

    [Column("TRV_Retorno")]
    [StringLength(10)]
    [Unicode(false)]
    public string? TrvRetorno { get; set; }

    [Column("TRV_Dias")]
    [StringLength(5)]
    [Unicode(false)]
    public string? TrvDias { get; set; }

    [InverseProperty("TrvCodigoNavigation")]
    public virtual ICollection<PetVacina> PetVacinas { get; set; } = new List<PetVacina>();
}
