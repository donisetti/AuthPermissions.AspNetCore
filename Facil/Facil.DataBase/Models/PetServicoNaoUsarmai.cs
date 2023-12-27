using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PET_SERVICO_NAO USARMAIS")]
public partial class PetServicoNaoUsarmai
{
    [Key]
    [Column("SER_Codigo")]
    public short SerCodigo { get; set; }

    [Column("SER_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SerDescricao { get; set; }

    [Column("SER_Valor", TypeName = "decimal(15, 2)")]
    public decimal? SerValor { get; set; }

    [Column("SER_Observacao")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SerObservacao { get; set; }
}
