using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("CARTAO_FIDELIDADE")]
public partial class CartaoFidelidade
{
    [Key]
    [Column("CARF_Codigo")]
    public int CarfCodigo { get; set; }

    [Column("PES_Codigo")]
    public int PesCodigo { get; set; }

    [Column("CARF_Nome")]
    [StringLength(100)]
    [Unicode(false)]
    public string CarfNome { get; set; } = null!;

    [Column("CARF_DataVencimento", TypeName = "smalldatetime")]
    public DateTime CarfDataVencimento { get; set; }

    [Column("CARF_Numero")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CarfNumero { get; set; }
}
