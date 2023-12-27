using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Keyless]
[Table("PET_PRODUTO_SERVICO_nao_usar")]
public partial class PetProdutoServicoNaoUsar
{
    [Column("PSE_Codigo")]
    public short? PseCodigo { get; set; }

    [Column("PSE_Observacao")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PseObservacao { get; set; }

    [Column("PRO_Codigo")]
    public int? ProCodigo { get; set; }

    [Column("CON_Codigo")]
    public int? ConCodigo { get; set; }
}
