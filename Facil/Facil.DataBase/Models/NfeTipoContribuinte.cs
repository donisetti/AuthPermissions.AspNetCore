using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("NFe_TIPO_CONTRIBUINTE")]
public partial class NfeTipoContribuinte
{
    [Key]
    [Column("indIEDest_Codigo")]
    public short IndIedestCodigo { get; set; }

    [Column("indIEDest_Descricao")]
    [StringLength(30)]
    [Unicode(false)]
    public string? IndIedestDescricao { get; set; }

    [InverseProperty("IndIedestCodigoNavigation")]
    public virtual ICollection<Pessoa> Pessoas { get; set; } = new List<Pessoa>();
}
