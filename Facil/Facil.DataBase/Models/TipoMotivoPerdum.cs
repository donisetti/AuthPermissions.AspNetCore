using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("TIPO_MOTIVO_PERDA")]
public partial class TipoMotivoPerdum
{
    [Key]
    [Column("TMP_Codigo")]
    public short TmpCodigo { get; set; }

    [Column("TMP_Descricao")]
    [StringLength(100)]
    [Unicode(false)]
    public string TmpDescricao { get; set; } = null!;

    [InverseProperty("TmpCodigoNavigation")]
    public virtual ICollection<PerdaInsumo> PerdaInsumos { get; set; } = new List<PerdaInsumo>();

    [InverseProperty("TmpCodigoNavigation")]
    public virtual ICollection<PerdaProduto> PerdaProdutos { get; set; } = new List<PerdaProduto>();
}
