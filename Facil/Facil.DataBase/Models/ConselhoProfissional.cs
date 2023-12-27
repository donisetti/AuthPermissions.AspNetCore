using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("CONSELHO_PROFISSIONAL")]
public partial class ConselhoProfissional
{
    [Key]
    [Column("CAL_Sigla")]
    [StringLength(20)]
    [Unicode(false)]
    public string CalSigla { get; set; } = null!;

    [Column("CAL_Descricao")]
    [StringLength(100)]
    [Unicode(false)]
    public string CalDescricao { get; set; } = null!;

    [InverseProperty("CalSiglaNavigation")]
    public virtual ICollection<Medico> Medicos { get; set; } = new List<Medico>();
}
