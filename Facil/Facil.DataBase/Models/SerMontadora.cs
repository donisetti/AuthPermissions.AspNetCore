using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("SER_MONTADORA")]
public partial class SerMontadora
{
    [Key]
    [Column("MON_Codigo")]
    public short MonCodigo { get; set; }

    [Column("MON_Descricao")]
    [StringLength(30)]
    [Unicode(false)]
    public string MonDescricao { get; set; } = null!;

    [InverseProperty("MonCodigoNavigation")]
    public virtual ICollection<SerCarro> SerCarros { get; set; } = new List<SerCarro>();
}
