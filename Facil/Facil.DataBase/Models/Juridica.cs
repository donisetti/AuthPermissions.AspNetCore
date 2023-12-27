using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("JURIDICA")]
public partial class Juridica
{
    [Key]
    [Column("PES_Codigo")]
    public int PesCodigo { get; set; }

    [Column("JUR_Cnpj")]
    [StringLength(15)]
    [Unicode(false)]
    public string JurCnpj { get; set; } = null!;

    [Column("JUR_RazaoSocial")]
    [StringLength(60)]
    [Unicode(false)]
    public string? JurRazaoSocial { get; set; }

    [Column("JUR_NomeFantasia")]
    [StringLength(60)]
    [Unicode(false)]
    public string? JurNomeFantasia { get; set; }

    [Column("JUR_InscricaoEstadual")]
    [StringLength(20)]
    [Unicode(false)]
    public string? JurInscricaoEstadual { get; set; }

    [Column("JUR_Dta_Fundacao", TypeName = "smalldatetime")]
    public DateTime? JurDtaFundacao { get; set; }

    [InverseProperty("ForCodigoInsumoNavigation")]
    public virtual ICollection<PerdaInsumo> PerdaInsumos { get; set; } = new List<PerdaInsumo>();

    [ForeignKey("PesCodigo")]
    [InverseProperty("Juridica")]
    public virtual Pessoa PesCodigoNavigation { get; set; } = null!;

    [InverseProperty("ForCodigoNavigation")]
    public virtual ICollection<SaidaInsumo> SaidaInsumos { get; set; } = new List<SaidaInsumo>();

    [InverseProperty("ForCodigoInsumoNavigation")]
    public virtual ICollection<TransferenciaInsumo> TransferenciaInsumos { get; set; } = new List<TransferenciaInsumo>();
}
