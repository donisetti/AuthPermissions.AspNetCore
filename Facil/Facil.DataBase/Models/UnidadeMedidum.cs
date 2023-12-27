using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("UNIDADE_MEDIDA")]
public partial class UnidadeMedidum
{
    [Key]
    [Column("UNI_Codigo")]
    public short UniCodigo { get; set; }

    [Column("UNI_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string UniDescricao { get; set; } = null!;

    [Column("UNI_Sigla")]
    [StringLength(3)]
    [Unicode(false)]
    public string UniSigla { get; set; } = null!;

    [InverseProperty("UniCodigoNavigation")]
    public virtual ICollection<EntradaUnidadeMedidum> EntradaUnidadeMedida { get; set; } = new List<EntradaUnidadeMedidum>();
}
