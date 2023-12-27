using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("TIPO_UNIDADE_FARMACOTECNICA")]
public partial class TipoUnidadeFarmacotecnica
{
    [Key]
    [Column("TUF_Codigo")]
    public short TufCodigo { get; set; }

    [Column("TUF_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string TufDescricao { get; set; } = null!;

    [InverseProperty("TufCodigoNavigation")]
    public virtual ICollection<SaidaInsumo> SaidaInsumos { get; set; } = new List<SaidaInsumo>();
}
