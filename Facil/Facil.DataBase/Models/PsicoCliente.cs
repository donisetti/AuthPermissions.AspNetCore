using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PSICO_CLIENTE")]
public partial class PsicoCliente
{
    [Key]
    [Column("PCLI_Codigo")]
    public int PcliCodigo { get; set; }

    [Column("PCLI_Nome")]
    [StringLength(100)]
    [Unicode(false)]
    public string PcliNome { get; set; } = null!;

    [Column("PCLI_DataCadastro", TypeName = "smalldatetime")]
    public DateTime PcliDataCadastro { get; set; }

    [Column("PCLI_UnidadeIdade")]
    public short? PcliUnidadeIdade { get; set; }

    [Column("PCLI_Sexo")]
    public short? PcliSexo { get; set; }

    [Column("PCLI_Cid")]
    [StringLength(20)]
    [Unicode(false)]
    public string? PcliCid { get; set; }

    [Column("PCLI_DataNascimento", TypeName = "smalldatetime")]
    public DateTime? PcliDataNascimento { get; set; }

    [Column("PCLI_Idade")]
    public short? PcliIdade { get; set; }

    [InverseProperty("PcliCodigoNavigation")]
    public virtual ICollection<DocumentoCliente> DocumentoClientes { get; set; } = new List<DocumentoCliente>();

    [InverseProperty("PcliCodigoNavigation")]
    public virtual ICollection<SaidaProduto> SaidaProdutos { get; set; } = new List<SaidaProduto>();
}
