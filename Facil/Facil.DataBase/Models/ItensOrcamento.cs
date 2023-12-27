using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("ITENS_ORCAMENTO")]
public partial class ItensOrcamento
{
    [Key]
    [Column("IOC_Codigo")]
    public long IocCodigo { get; set; }

    [Column("ORC_Codigo")]
    public long OrcCodigo { get; set; }

    [Column("IOC_Quantidade", TypeName = "decimal(10, 3)")]
    public decimal IocQuantidade { get; set; }

    [Column("IOC_QuantidadeEstorno", TypeName = "decimal(10, 3)")]
    public decimal IocQuantidadeEstorno { get; set; }

    [Column("IOC_CustoFabrica", TypeName = "decimal(15, 2)")]
    public decimal IocCustoFabrica { get; set; }

    [Column("IOC_ValorVendaUnitario", TypeName = "decimal(15, 2)")]
    public decimal IocValorVendaUnitario { get; set; }

    [Column("IOC_ValorDescontoProduto", TypeName = "decimal(15, 2)")]
    public decimal IocValorDescontoProduto { get; set; }

    [Column("IOC_DataEstorno", TypeName = "smalldatetime")]
    public DateTime IocDataEstorno { get; set; }

    [Column("PRO_Codigo")]
    public int ProCodigo { get; set; }

    [Column("IOC_Descricao")]
    [StringLength(60)]
    [Unicode(false)]
    public string? IocDescricao { get; set; }

    [Column("IOC_Apresentacao")]
    [StringLength(60)]
    [Unicode(false)]
    public string? IocApresentacao { get; set; }
}
