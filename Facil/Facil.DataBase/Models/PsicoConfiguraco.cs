using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PSICO_CONFIGURACOES")]
public partial class PsicoConfiguraco
{
    [Key]
    [Column("PSI_Codigo")]
    public int PsiCodigo { get; set; }

    [Column("PSI_HashIdentificacao")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PsiHashIdentificacao { get; set; }

    [Column("PSI_DataInicioPeriodo", TypeName = "smalldatetime")]
    public DateTime PsiDataInicioPeriodo { get; set; }

    [Column("PSI_DataFimPeriodo", TypeName = "smalldatetime")]
    public DateTime PsiDataFimPeriodo { get; set; }

    [Column("PSI_DataEnvioAnvisa", TypeName = "smalldatetime")]
    public DateTime? PsiDataEnvioAnvisa { get; set; }

    [Column("PSI_DataGeracaoArquivo", TypeName = "smalldatetime")]
    public DateTime PsiDataGeracaoArquivo { get; set; }

    [Column("PSI_CaminhoArquivo")]
    [StringLength(150)]
    [Unicode(false)]
    public string PsiCaminhoArquivo { get; set; } = null!;

    [Column("PSI_ValidadoAnvisa")]
    [StringLength(1)]
    [Unicode(false)]
    public string PsiValidadoAnvisa { get; set; } = null!;
}
