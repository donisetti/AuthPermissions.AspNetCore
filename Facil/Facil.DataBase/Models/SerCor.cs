using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("SER_COR")]
public partial class SerCor
{
    [Key]
    [Column("COR_Codigo")]
    public short CorCodigo { get; set; }

    [Column("COR_Descricao")]
    [StringLength(30)]
    [Unicode(false)]
    public string CorDescricao { get; set; } = null!;

    [InverseProperty("CorCodigoNavigation")]
    public virtual ICollection<SerEquipamento> SerEquipamentos { get; set; } = new List<SerEquipamento>();

    [InverseProperty("CorCodigoNavigation")]
    public virtual ICollection<SerVeiculo> SerVeiculos { get; set; } = new List<SerVeiculo>();
}
