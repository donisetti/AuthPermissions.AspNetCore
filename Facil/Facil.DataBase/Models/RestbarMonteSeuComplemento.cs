using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Keyless]
[Table("RESTBAR_MONTE_SEU_COMPLEMENTO")]
public partial class RestbarMonteSeuComplemento
{
    [Column("MSC_Codigo")]
    public short? MscCodigo { get; set; }

    [Column("RBT_Codigo")]
    public short? RbtCodigo { get; set; }

    [Column("RBP_Codigo")]
    public short? RbpCodigo { get; set; }

    [Column("PRO_Codigo_Principal")]
    public short? ProCodigoPrincipal { get; set; }

    [Column("PRO_Descricao_Principal")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProDescricaoPrincipal { get; set; }

    [Column("MSP_Observacao")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MspObservacao { get; set; }

    [Column("MSP_ExisteItensComplemento")]
    public bool? MspExisteItensComplemento { get; set; }

    [Column("PRO_Item")]
    public int? ProItem { get; set; }
}
