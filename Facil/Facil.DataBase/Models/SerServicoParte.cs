using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("SER_SERVICO_PARTE")]
public partial class SerServicoParte
{
    [Key]
    [Column("SERPAR_Codigo")]
    public int SerparCodigo { get; set; }

    [Column("SERPAR_DataMovimento", TypeName = "smalldatetime")]
    public DateTime? SerparDataMovimento { get; set; }

    [Column("SERPAR_DefeitoReclamado")]
    [StringLength(200)]
    [Unicode(false)]
    public string? SerparDefeitoReclamado { get; set; }

    [Column("SERPAR_SolucaoDefeito")]
    [StringLength(200)]
    [Unicode(false)]
    public string? SerparSolucaoDefeito { get; set; }

    [Column("SER_Codigo")]
    public int SerCodigo { get; set; }

    [Column("PAR_Codigo")]
    public short ParCodigo { get; set; }

    [InverseProperty("SerparCodigoNavigation")]
    public virtual ICollection<ItensVendum> ItensVenda { get; set; } = new List<ItensVendum>();

    [ForeignKey("ParCodigo")]
    [InverseProperty("SerServicoPartes")]
    public virtual SerParte ParCodigoNavigation { get; set; } = null!;

    [ForeignKey("SerCodigo")]
    [InverseProperty("SerServicoPartes")]
    public virtual SerServico SerCodigoNavigation { get; set; } = null!;

    [InverseProperty("SerparCodigoNavigation")]
    public virtual ICollection<SerServicoParteTecnico> SerServicoParteTecnicos { get; set; } = new List<SerServicoParteTecnico>();
}
