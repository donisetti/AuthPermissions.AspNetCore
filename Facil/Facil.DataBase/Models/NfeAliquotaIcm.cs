using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[PrimaryKey("UfOrigem", "UfDestino")]
[Table("NFe_ALIQUOTA_ICMS")]
public partial class NfeAliquotaIcm
{
    [Key]
    [Column("UF_Origem")]
    [StringLength(2)]
    [Unicode(false)]
    public string UfOrigem { get; set; } = null!;

    [Key]
    [Column("UF_Destino")]
    [StringLength(2)]
    [Unicode(false)]
    public string UfDestino { get; set; } = null!;

    [Column("Valor_AliquotaICMS", TypeName = "decimal(10, 3)")]
    public decimal ValorAliquotaIcms { get; set; }

    [Column("ValorPercentual_Reducao", TypeName = "decimal(10, 3)")]
    public decimal ValorPercentualReducao { get; set; }
}
