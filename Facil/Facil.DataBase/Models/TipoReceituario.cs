using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("TIPO_RECEITUARIO")]
public partial class TipoReceituario
{
    [Key]
    [Column("TIO_Codigo")]
    public short TioCodigo { get; set; }

    [Column("TIO_Descricao")]
    [StringLength(100)]
    [Unicode(false)]
    public string TioDescricao { get; set; } = null!;

    [InverseProperty("TioCodigoNavigation")]
    public virtual ICollection<Grupo> Grupos { get; set; } = new List<Grupo>();

    [InverseProperty("TioCodigoNavigation")]
    public virtual ICollection<SaidaInsumo> SaidaInsumos { get; set; } = new List<SaidaInsumo>();

    [InverseProperty("TioCodigoNavigation")]
    public virtual ICollection<SaidaProduto> SaidaProdutos { get; set; } = new List<SaidaProduto>();

    [InverseProperty("TioCodigoNavigation")]
    public virtual ICollection<Substancium> Substancia { get; set; } = new List<Substancium>();
}
