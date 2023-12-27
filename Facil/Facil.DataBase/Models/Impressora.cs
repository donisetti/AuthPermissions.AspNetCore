using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("IMPRESSORA")]
public partial class Impressora
{
    [Key]
    [Column("IMP_Codigo")]
    public short ImpCodigo { get; set; }

    [Column("IMP_Descricao")]
    [StringLength(30)]
    [Unicode(false)]
    public string ImpDescricao { get; set; } = null!;

    [InverseProperty("ImpCodigoNavigation")]
    public virtual ICollection<FormaPagamentoImpressora> FormaPagamentoImpressoras { get; set; } = new List<FormaPagamentoImpressora>();

    [InverseProperty("ImpCodigoNavigation")]
    public virtual ICollection<RegistroEcf> RegistroEcfs { get; set; } = new List<RegistroEcf>();
}
