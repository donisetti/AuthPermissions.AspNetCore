using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("ORCAMENTO")]
public partial class Orcamento
{
    [Key]
    [Column("ORC_Codigo")]
    public long OrcCodigo { get; set; }

    [Column("ORC_DataLancamento", TypeName = "datetime")]
    public DateTime OrcDataLancamento { get; set; }

    [Column("ORC_Valor", TypeName = "decimal(15, 2)")]
    public decimal OrcValor { get; set; }

    [Column("ORC_DataEstorno", TypeName = "smalldatetime")]
    public DateTime OrcDataEstorno { get; set; }

    [Column("ORC_UsuarioEstorno")]
    public short? OrcUsuarioEstorno { get; set; }

    [Column("Vda_Vendedor")]
    public short VdaVendedor { get; set; }

    [Column("PES_Codigo")]
    public int PesCodigo { get; set; }

    [Column("VDA_Codigo")]
    public long? VdaCodigo { get; set; }

    [Column("ORC_Observacoes")]
    [StringLength(200)]
    [Unicode(false)]
    public string? OrcObservacoes { get; set; }

    [ForeignKey("PesCodigo")]
    [InverseProperty("Orcamentos")]
    public virtual Pessoa PesCodigoNavigation { get; set; } = null!;

    [InverseProperty("OrcCodigoNavigation")]
    public virtual ICollection<Vendum> Venda { get; set; } = new List<Vendum>();
}
