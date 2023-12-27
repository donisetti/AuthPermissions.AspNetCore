using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("SER_EQUIPAMENTO_SERVICO")]
public partial class SerEquipamentoServico
{
    [Key]
    [Column("EQUISER_Codigo")]
    public int EquiserCodigo { get; set; }

    [Column("EQUI_Codigo")]
    public int? EquiCodigo { get; set; }

    [Column("SER_Codigo")]
    public int? SerCodigo { get; set; }

    [ForeignKey("EquiCodigo")]
    [InverseProperty("SerEquipamentoServicos")]
    public virtual SerEquipamento? EquiCodigoNavigation { get; set; }

    [ForeignKey("SerCodigo")]
    [InverseProperty("SerEquipamentoServicos")]
    public virtual SerServico? SerCodigoNavigation { get; set; }
}
