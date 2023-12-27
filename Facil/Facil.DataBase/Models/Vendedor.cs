using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("VENDEDOR")]
public partial class Vendedor
{
    [Key]
    [Column("VEN_Codigo")]
    public int VenCodigo { get; set; }

    [Column("VEN_Nome")]
    [StringLength(60)]
    [Unicode(false)]
    public string VenNome { get; set; } = null!;

    [Column("VEN_Email")]
    [StringLength(150)]
    [Unicode(false)]
    public string VenEmail { get; set; } = null!;

    [Column("VEN_Senha")]
    [StringLength(50)]
    [Unicode(false)]
    public string VenSenha { get; set; } = null!;
}
