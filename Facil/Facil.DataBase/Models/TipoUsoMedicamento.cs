using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("TIPO_USO_MEDICAMENTO")]
public partial class TipoUsoMedicamento
{
    [Key]
    [Column("TUM_Codigo")]
    public short TumCodigo { get; set; }

    [Column("TUM_Descricao")]
    [StringLength(100)]
    [Unicode(false)]
    public string TumDescricao { get; set; } = null!;

    [InverseProperty("TumCodigoNavigation")]
    public virtual ICollection<SaidaInsumo> SaidaInsumos { get; set; } = new List<SaidaInsumo>();

    [InverseProperty("TumCodigoNavigation")]
    public virtual ICollection<SaidaProduto> SaidaProdutos { get; set; } = new List<SaidaProduto>();
}
