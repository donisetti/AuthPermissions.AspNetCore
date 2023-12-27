using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PET_CONSULTA_ITEM_nao_usar")]
public partial class PetConsultaItemNaoUsar
{
    [Key]
    [Column("CIT_Codigo")]
    public int CitCodigo { get; set; }

    [Column("CON_Codigo")]
    public int? ConCodigo { get; set; }

    [Column("PRO_Codigo")]
    public int? ProCodigo { get; set; }

    [Column("PRO_Quantidade", TypeName = "decimal(10, 3)")]
    public decimal? ProQuantidade { get; set; }

    [Column("PRO_Venda", TypeName = "decimal(15, 2)")]
    public decimal? ProVenda { get; set; }
}
