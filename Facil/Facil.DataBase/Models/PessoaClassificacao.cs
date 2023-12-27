using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PESSOA_CLASSIFICACAO")]
public partial class PessoaClassificacao
{
    [Key]
    [Column("PCLAS_Codigo")]
    public short PclasCodigo { get; set; }

    [Column("PES_Codigo")]
    public int? PesCodigo { get; set; }

    [Column("CLA_codigo")]
    public short? ClaCodigo { get; set; }

    [Column("PCLAS_Desconto", TypeName = "decimal(15, 3)")]
    public decimal? PclasDesconto { get; set; }

    [ForeignKey("ClaCodigo")]
    [InverseProperty("PessoaClassificacaos")]
    public virtual Classificacao? ClaCodigoNavigation { get; set; }

    [ForeignKey("PesCodigo")]
    [InverseProperty("PessoaClassificacaos")]
    public virtual Pessoa? PesCodigoNavigation { get; set; }
}
