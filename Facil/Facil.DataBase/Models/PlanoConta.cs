using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PLANO_CONTAS")]
public partial class PlanoConta
{
    [Key]
    [Column("PCT_CodigoReduzido")]
    public int PctCodigoReduzido { get; set; }

    [Column("PCT_CodigoConta")]
    [StringLength(50)]
    [Unicode(false)]
    public string PctCodigoConta { get; set; } = null!;

    [Column("PCT_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string PctDescricao { get; set; } = null!;

    [Column("PCT_Grau")]
    public short PctGrau { get; set; }

    [Column("PCT_Conta")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PctConta { get; set; }

    [Column("PCT_SensibilizaCaixa")]
    [StringLength(1)]
    [Unicode(false)]
    public string PctSensibilizaCaixa { get; set; } = null!;

    [Column("PCT_ContaSistema")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PctContaSistema { get; set; }

    [InverseProperty("PctCodigoReduzidoNavigation")]
    public virtual ICollection<CaixaLancamento> CaixaLancamentos { get; set; } = new List<CaixaLancamento>();

    [InverseProperty("PctCodigoReduzidoNavigation")]
    public virtual ICollection<FormaPagamento> FormaPagamentos { get; set; } = new List<FormaPagamento>();

    [InverseProperty("PctCodigoReduzidoNavigation")]
    public virtual ICollection<Fornecedore> Fornecedores { get; set; } = new List<Fornecedore>();
}
