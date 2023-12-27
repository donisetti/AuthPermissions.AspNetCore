using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Keyless]
[Table("NFe_IBPTAX_Tabela")]
public partial class NfeIbptaxTabela
{
    [Column("IBPT_CodigoNCM")]
    [StringLength(10)]
    [Unicode(false)]
    public string IbptCodigoNcm { get; set; } = null!;

    [Column("IBPT_CodigoExcecaoNCM")]
    [StringLength(4)]
    [Unicode(false)]
    public string? IbptCodigoExcecaoNcm { get; set; }

    /// <summary>
    /// 0 para NCM
    /// 1 para NBS (servicos)
    /// 2 para Item da LC 116
    /// </summary>
    [Column("IBPT_Tabela")]
    public short IbptTabela { get; set; }

    [Column("IBPT_Descricao")]
    [StringLength(400)]
    [Unicode(false)]
    public string? IbptDescricao { get; set; }

    /// <summary>
    /// A Aliquota nacional é utilizada quando o produto for de origem brasileira. 
    /// </summary>
    [Column("IBPT_AliquotaNacional", TypeName = "decimal(5, 2)")]
    public decimal IbptAliquotaNacional { get; set; }

    /// <summary>
    /// A Aliquota de importacao é utilizada quando a origem do produto for de fora do brasil
    /// </summary>
    [Column("IBPT_AliquotaImportacao", TypeName = "decimal(5, 2)")]
    public decimal IbptAliquotaImportacao { get; set; }

    [Column("IBPT_VersaoArquivoIBPTAX")]
    [StringLength(10)]
    [Unicode(false)]
    public string IbptVersaoArquivoIbptax { get; set; } = null!;

    [Column("IBPT_CEST")]
    [StringLength(7)]
    [Unicode(false)]
    public string? IbptCest { get; set; }

    [Column("IBPT_Codigo")]
    public int IbptCodigo { get; set; }
}
