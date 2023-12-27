using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("NFe_FATURA")]
public partial class NfeFatura
{
    [Key]
    [Column("NFe_Numero")]
    [StringLength(9)]
    [Unicode(false)]
    public string NfeNumero { get; set; } = null!;

    [Column("FAT_Numero")]
    [StringLength(60)]
    [Unicode(false)]
    public string FatNumero { get; set; } = null!;

    [Column("FAT_ValorOrigem", TypeName = "decimal(15, 2)")]
    public decimal FatValorOrigem { get; set; }

    [Column("FAT_ValorDesconto", TypeName = "decimal(15, 2)")]
    public decimal FatValorDesconto { get; set; }

    [Column("FAT_ValorLiquido", TypeName = "decimal(15, 2)")]
    public decimal FatValorLiquido { get; set; }
}
