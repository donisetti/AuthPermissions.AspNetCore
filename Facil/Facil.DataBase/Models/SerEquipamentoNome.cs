using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("SER_EQUIPAMENTO_NOME")]
public partial class SerEquipamentoNome
{
    [Key]
    [Column("EQUINOM_Codigo")]
    public int EquinomCodigo { get; set; }

    [Column("EQUINOM_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EquinomDescricao { get; set; }

    [Column("EQUIMOD_Codigo")]
    public int? EquimodCodigo { get; set; }

    [ForeignKey("EquimodCodigo")]
    [InverseProperty("SerEquipamentoNomes")]
    public virtual SerEquipamentoModelo? EquimodCodigoNavigation { get; set; }

    [InverseProperty("EquinomCodigoNavigation")]
    public virtual ICollection<SerEquipamento> SerEquipamentos { get; set; } = new List<SerEquipamento>();
}
