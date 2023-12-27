using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("SUBSTANCIA")]
public partial class Substancium
{
    [Key]
    [Column("SUB_Codigo")]
    public short SubCodigo { get; set; }

    [Column("SUB_Descricao")]
    [StringLength(100)]
    [Unicode(false)]
    public string SubDescricao { get; set; } = null!;

    [Column("GRP_Codigo")]
    [StringLength(2)]
    [Unicode(false)]
    public string? GrpCodigo { get; set; }

    [Column("SUB_DCB")]
    [StringLength(10)]
    [Unicode(false)]
    public string? SubDcb { get; set; }

    [Column("SUB_CAS")]
    [StringLength(20)]
    [Unicode(false)]
    public string? SubCas { get; set; }

    [Column("SUB_DataInclusao", TypeName = "smalldatetime")]
    public DateTime? SubDataInclusao { get; set; }

    [Column("NUM_Concent")]
    [StringLength(10)]
    [Unicode(false)]
    public string? NumConcent { get; set; }

    [Column("TIO_Codigo")]
    public short? TioCodigo { get; set; }

    [Column("SUB_Controlada")]
    public bool? SubControlada { get; set; }

    [InverseProperty("SubCodigoNavigation")]
    public virtual ICollection<EntradaInsumo> EntradaInsumos { get; set; } = new List<EntradaInsumo>();

    [ForeignKey("GrpCodigo")]
    [InverseProperty("Substancia")]
    public virtual Grupo? GrpCodigoNavigation { get; set; }

    [InverseProperty("SubCodigoNavigation")]
    public virtual ICollection<PerdaInsumo> PerdaInsumos { get; set; } = new List<PerdaInsumo>();

    [InverseProperty("SubCodigoNavigation")]
    public virtual ICollection<SaidaInsumo> SaidaInsumos { get; set; } = new List<SaidaInsumo>();

    [ForeignKey("TioCodigo")]
    [InverseProperty("Substancia")]
    public virtual TipoReceituario? TioCodigoNavigation { get; set; }

    [InverseProperty("SubCodigoNavigation")]
    public virtual ICollection<TransferenciaInsumo> TransferenciaInsumos { get; set; } = new List<TransferenciaInsumo>();
}
