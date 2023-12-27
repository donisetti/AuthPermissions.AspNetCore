using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("TIPO_UNIDADE_INSUMO")]
public partial class TipoUnidadeInsumo
{
    [Key]
    [Column("TUI_Codigo")]
    public short TuiCodigo { get; set; }

    [Column("TUI_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string TuiDescricao { get; set; } = null!;

    [InverseProperty("TuiCodigoNavigation")]
    public virtual ICollection<EntradaInsumo> EntradaInsumos { get; set; } = new List<EntradaInsumo>();

    [InverseProperty("TuiCodigoNavigation")]
    public virtual ICollection<PerdaInsumo> PerdaInsumos { get; set; } = new List<PerdaInsumo>();

    [InverseProperty("TuiCodigoNavigation")]
    public virtual ICollection<SaidaInsumo> SaidaInsumos { get; set; } = new List<SaidaInsumo>();

    [InverseProperty("TuiCodigoNavigation")]
    public virtual ICollection<TransferenciaInsumo> TransferenciaInsumos { get; set; } = new List<TransferenciaInsumo>();
}
