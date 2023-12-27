using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("GRUPO")]
public partial class Grupo
{
    [Key]
    [Column("GRP_Codigo")]
    [StringLength(2)]
    [Unicode(false)]
    public string GrpCodigo { get; set; } = null!;

    [Column("GRP_Descricao")]
    [StringLength(30)]
    [Unicode(false)]
    public string? GrpDescricao { get; set; }

    [Column("TIO_Codigo")]
    public short? TioCodigo { get; set; }

    [InverseProperty("GrpCodigoNavigation")]
    public virtual ICollection<Substancium> Substancia { get; set; } = new List<Substancium>();

    [ForeignKey("TioCodigo")]
    [InverseProperty("Grupos")]
    public virtual TipoReceituario? TioCodigoNavigation { get; set; }
}
