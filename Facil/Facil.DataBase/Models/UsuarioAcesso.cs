using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Keyless]
[Table("USUARIO_ACESSO")]
public partial class UsuarioAcesso
{
    [Column("USR_Codigo")]
    public int? UsrCodigo { get; set; }

    [Column("USA_Grau_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? UsaGrau1 { get; set; }

    [Column("USA_Grau_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string UsaGrau2 { get; set; } = null!;

    [Column("USA_Grau_3")]
    [StringLength(50)]
    [Unicode(false)]
    public string UsaGrau3 { get; set; } = null!;
}
