using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[PrimaryKey("NfeNumero", "DupNumero")]
[Table("NFe_DUPLICATA")]
public partial class NfeDuplicatum
{
    [Key]
    [Column("NFe_Numero")]
    [StringLength(9)]
    [Unicode(false)]
    public string NfeNumero { get; set; } = null!;

    [Key]
    [Column("DUP_Numero")]
    [StringLength(60)]
    [Unicode(false)]
    public string DupNumero { get; set; } = null!;

    [Column("DUP_DataVencimento", TypeName = "smalldatetime")]
    public DateTime DupDataVencimento { get; set; }

    [Column("DUP_ValorDuplicata", TypeName = "decimal(15, 2)")]
    public decimal DupValorDuplicata { get; set; }
}
