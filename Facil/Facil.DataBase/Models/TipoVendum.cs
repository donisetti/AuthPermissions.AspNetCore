using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("TIPO_VENDA")]
public partial class TipoVendum
{
    [Key]
    [Column("TPV_Codigo")]
    public short TpvCodigo { get; set; }

    [Column("TPV_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string TpvDescricao { get; set; } = null!;

    [InverseProperty("TpvCodigoNavigation")]
    public virtual ICollection<ItensVendum> ItensVenda { get; set; } = new List<ItensVendum>();

    [InverseProperty("TpvCodigoNavigation")]
    public virtual ICollection<Vendum> Venda { get; set; } = new List<Vendum>();
}
