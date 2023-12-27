using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("SER_PARTE")]
public partial class SerParte
{
    [Key]
    [Column("PAR_Codigo")]
    public short ParCodigo { get; set; }

    [Column("PAR_Descricao")]
    [StringLength(30)]
    [Unicode(false)]
    public string? ParDescricao { get; set; }

    [InverseProperty("ParCodigoNavigation")]
    public virtual ICollection<SerServicoParte> SerServicoPartes { get; set; } = new List<SerServicoParte>();
}
