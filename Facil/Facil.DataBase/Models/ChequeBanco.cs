using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("CHEQUE_BANCO")]
public partial class ChequeBanco
{
    [Key]
    [Column("BAN_Codigo")]
    public short BanCodigo { get; set; }

    [Column("BAN_Numero")]
    [StringLength(5)]
    [Unicode(false)]
    public string? BanNumero { get; set; }

    [Column("BAN_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BanDescricao { get; set; }

    [InverseProperty("BanCodigoNavigation")]
    public virtual ICollection<ChequeSacado> ChequeSacados { get; set; } = new List<ChequeSacado>();
}
