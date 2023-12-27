using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Keyless]
[Table("AUTORIZADO")]
public partial class Autorizado
{
    [Column("AUT_Codigo")]
    public int? AutCodigo { get; set; }

    [Column("AUT_Nome")]
    [StringLength(80)]
    [Unicode(false)]
    public string? AutNome { get; set; }

    [Column("AUT_Grau")]
    [StringLength(50)]
    [Unicode(false)]
    public string? AutGrau { get; set; }

    [Column("AUT_DataNascimento", TypeName = "smalldatetime")]
    public DateTime? AutDataNascimento { get; set; }

    [Column("PES_Codigo")]
    public int? PesCodigo { get; set; }

    [ForeignKey("PesCodigo")]
    public virtual Pessoa? PesCodigoNavigation { get; set; }
}
