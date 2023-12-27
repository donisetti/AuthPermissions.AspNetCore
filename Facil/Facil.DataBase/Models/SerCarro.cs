using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("SER_CARRO")]
public partial class SerCarro
{
    [Key]
    [Column("CAR_Codigo")]
    public short CarCodigo { get; set; }

    [Column("CAR_Descricao")]
    [StringLength(30)]
    [Unicode(false)]
    public string CarDescricao { get; set; } = null!;

    [Column("MON_Codigo")]
    public short MonCodigo { get; set; }

    [ForeignKey("MonCodigo")]
    [InverseProperty("SerCarros")]
    public virtual SerMontadora MonCodigoNavigation { get; set; } = null!;

    [InverseProperty("CarCodigoNavigation")]
    public virtual ICollection<SerVeiculo> SerVeiculos { get; set; } = new List<SerVeiculo>();
}
