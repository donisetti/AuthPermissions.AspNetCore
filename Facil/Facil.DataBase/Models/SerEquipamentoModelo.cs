using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("SER_EQUIPAMENTO_MODELO")]
public partial class SerEquipamentoModelo
{
    [Key]
    [Column("EQUIMOD_Codigo")]
    public int EquimodCodigo { get; set; }

    [Column("EQUIMOD_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EquimodDescricao { get; set; }

    [InverseProperty("EquimodCodigoNavigation")]
    public virtual ICollection<SerEquipamentoNome> SerEquipamentoNomes { get; set; } = new List<SerEquipamentoNome>();
}
