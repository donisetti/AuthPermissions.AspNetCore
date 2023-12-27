using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("ESTOQUE_CLIENTE")]
public partial class EstoqueCliente
{
    [Key]
    [Column("IVD_Codigo")]
    public long IvdCodigo { get; set; }

    [Column("VDA_Codigo")]
    public long VdaCodigo { get; set; }

    [Column("ECL_QuantidadeEntregue", TypeName = "decimal(10, 3)")]
    public decimal EclQuantidadeEntregue { get; set; }

    [Column("PRO_Codigo")]
    public int ProCodigo { get; set; }
}
