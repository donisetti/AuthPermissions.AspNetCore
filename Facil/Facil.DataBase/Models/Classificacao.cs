using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("CLASSIFICACAO")]
public partial class Classificacao
{
    [Key]
    [Column("CLA_Codigo")]
    public short ClaCodigo { get; set; }

    [Column("CLA_Descricao")]
    [StringLength(30)]
    [Unicode(false)]
    public string ClaDescricao { get; set; } = null!;

    [Column("CLA_Pct_DescAVista", TypeName = "decimal(5, 2)")]
    public decimal? ClaPctDescAvista { get; set; }

    [Column("CLA_Dta_InicioDescAVista", TypeName = "datetime")]
    public DateTime? ClaDtaInicioDescAvista { get; set; }

    [Column("CLA_Dta_FinalDescAVista", TypeName = "datetime")]
    public DateTime? ClaDtaFinalDescAvista { get; set; }

    [Column("CLA_DescAVistaAtivo")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ClaDescAvistaAtivo { get; set; }

    [Column("CLA_Pct_DescAPrazo", TypeName = "decimal(5, 2)")]
    public decimal? ClaPctDescAprazo { get; set; }

    [Column("CLA_Dta_InicioDescAPrazo", TypeName = "datetime")]
    public DateTime? ClaDtaInicioDescAprazo { get; set; }

    [Column("CLA_Dta_FinalDescAPrazo", TypeName = "datetime")]
    public DateTime? ClaDtaFinalDescAprazo { get; set; }

    [Column("CLA_DescAPrazoAtivo")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ClaDescAprazoAtivo { get; set; }

    [Column("CLA_ImprimirEm")]
    [StringLength(30)]
    [Unicode(false)]
    public string? ClaImprimirEm { get; set; }

    [Column("CLA_UsaComplemento")]
    public bool? ClaUsaComplemento { get; set; }

    [Column("CLA_UsaSomenteObsComp")]
    public bool? ClaUsaSomenteObsComp { get; set; }

    [InverseProperty("ClaCodigoNavigation")]
    public virtual ICollection<PessoaClassificacao> PessoaClassificacaos { get; set; } = new List<PessoaClassificacao>();

    [InverseProperty("ClaCodigoNavigation")]
    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
