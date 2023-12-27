using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Keyless]
[Table("RESTBAR_ITENS_COMPLEMENTO")]
public partial class RestbarItensComplemento
{
    [Column("PIC_Codigo")]
    public short? PicCodigo { get; set; }

    [Column("MSC_Codigo")]
    public short? MscCodigo { get; set; }

    [Column("PRO_Codigo")]
    public short? ProCodigo { get; set; }

    [Column("PRO_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProDescricao { get; set; }

    [Column("PRO_Quantidade", TypeName = "decimal(15, 2)")]
    public decimal? ProQuantidade { get; set; }

    [Column("PRO_ValorVendaUnitario", TypeName = "decimal(15, 2)")]
    public decimal? ProValorVendaUnitario { get; set; }
}
