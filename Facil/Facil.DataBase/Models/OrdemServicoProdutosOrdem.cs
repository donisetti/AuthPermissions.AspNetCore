using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("ORDEM_SERVICO_PRODUTOS_ORDEM")]
public partial class OrdemServicoProdutosOrdem
{
    [Key]
    [Column("IVD_Codigo")]
    public int IvdCodigo { get; set; }

    [Column("IPOS_Ordem")]
    [StringLength(15)]
    [Unicode(false)]
    public string? IposOrdem { get; set; }

    [Column("IPOS_ItemOrdem")]
    public int? IposItemOrdem { get; set; }
}
