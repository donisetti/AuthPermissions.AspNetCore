using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("COPS_MOVIMENTO")]
public partial class CopsMovimento
{
    [Key]
    [Column("MOV_Codigo")]
    public long MovCodigo { get; set; }

    [Column("MOV_DataLancamento", TypeName = "smalldatetime")]
    public DateTime MovDataLancamento { get; set; }

    [Column("MOV_DataReceita", TypeName = "smalldatetime")]
    public DateTime? MovDataReceita { get; set; }

    [Column("MOV_DataEstorno", TypeName = "smalldatetime")]
    public DateTime? MovDataEstorno { get; set; }

    [Column("PES_Codigo")]
    public int PesCodigo { get; set; }

    [Column("MED_Codigo")]
    public int? MedCodigo { get; set; }

    [Column("USU_Codigo")]
    public short UsuCodigo { get; set; }

    [InverseProperty("MovCodigoNavigation")]
    public virtual ICollection<CopsMovimentoIten> CopsMovimentoItens { get; set; } = new List<CopsMovimentoIten>();

    [ForeignKey("MedCodigo")]
    [InverseProperty("CopsMovimentos")]
    public virtual Medico? MedCodigoNavigation { get; set; }

    [ForeignKey("PesCodigo")]
    [InverseProperty("CopsMovimentos")]
    public virtual Pessoa PesCodigoNavigation { get; set; } = null!;

    [ForeignKey("UsuCodigo")]
    [InverseProperty("CopsMovimentos")]
    public virtual Usuario UsuCodigoNavigation { get; set; } = null!;
}
