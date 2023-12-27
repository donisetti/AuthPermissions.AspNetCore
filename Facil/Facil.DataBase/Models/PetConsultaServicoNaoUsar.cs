using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PET_CONSULTA_SERVICO_nao_usar")]
public partial class PetConsultaServicoNaoUsar
{
    [Key]
    [Column("CSE_Codigo")]
    public int CseCodigo { get; set; }

    [Column("CON_Codigo")]
    public int? ConCodigo { get; set; }

    [Column("SER_Codigo")]
    public short? SerCodigo { get; set; }

    [Column("SER_Valor", TypeName = "decimal(15, 2)")]
    public decimal? SerValor { get; set; }

    [Column("SER_Quantidade", TypeName = "decimal(10, 3)")]
    public decimal? SerQuantidade { get; set; }
}
