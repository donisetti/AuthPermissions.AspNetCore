using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("FISICA_Tombstone")]
public partial class FisicaTombstone
{
    [Key]
    [Column("PES_Codigo")]
    public int PesCodigo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeletionDate { get; set; }
}
