using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("MESA")]
public partial class Mesa
{
    [Key]
    [Column("MSA_Codigo")]
    public short MsaCodigo { get; set; }

    [Column("MSA_Status_Mesa")]
    public bool MsaStatusMesa { get; set; }

    [InverseProperty("MsaCodigoNavigation")]
    public virtual ICollection<MesaPedido> MesaPedidos { get; set; } = new List<MesaPedido>();
}
