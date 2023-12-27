using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("FABRICANTE")]
public partial class Fabricante
{
    [Key]
    [Column("FAB_Codigo")]
    public short FabCodigo { get; set; }

    [Column("FAB_Descricao")]
    [StringLength(30)]
    [Unicode(false)]
    public string FabDescricao { get; set; } = null!;

    [Column("FAB_Endereco")]
    [StringLength(40)]
    [Unicode(false)]
    public string? FabEndereco { get; set; }

    [Column("FAB_Complemento")]
    [StringLength(30)]
    [Unicode(false)]
    public string? FabComplemento { get; set; }

    [Column("FAB_Cidade")]
    [StringLength(30)]
    [Unicode(false)]
    public string? FabCidade { get; set; }

    [Column("FAB_Estado")]
    [StringLength(3)]
    [Unicode(false)]
    public string? FabEstado { get; set; }

    [Column("FAB_Cep")]
    [StringLength(12)]
    [Unicode(false)]
    public string? FabCep { get; set; }

    [Column("FAB_Telefone")]
    [StringLength(100)]
    [Unicode(false)]
    public string? FabTelefone { get; set; }

    [Column("FAB_EMAIL")]
    [StringLength(200)]
    [Unicode(false)]
    public string? FabEmail { get; set; }

    [Column("FAB_CodigoFAI")]
    public long? FabCodigoFai { get; set; }

    [Column("FAB_Bairro")]
    [StringLength(30)]
    [Unicode(false)]
    public string? FabBairro { get; set; }

    [InverseProperty("FabCodigoNavigation")]
    public virtual ICollection<FabricanteDistribuidora> FabricanteDistribuidoras { get; set; } = new List<FabricanteDistribuidora>();

    [InverseProperty("FabCodigoNavigation")]
    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
