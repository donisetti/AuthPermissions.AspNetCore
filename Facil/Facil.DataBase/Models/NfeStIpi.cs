using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("NFe_ST_IPI")]
public partial class NfeStIpi
{
    [Key]
    [Column("STIPI_Codigo")]
    [StringLength(3)]
    [Unicode(false)]
    public string StipiCodigo { get; set; } = null!;

    [Column("STIPI_Descricao")]
    [StringLength(150)]
    [Unicode(false)]
    public string StipiDescricao { get; set; } = null!;
}
