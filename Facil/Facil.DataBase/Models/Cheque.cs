using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("CHEQUE")]
public partial class Cheque
{
    [Key]
    [Column("CHE_Codigo")]
    public int CheCodigo { get; set; }

    [Column("CHE_Numero")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CheNumero { get; set; }

    [Column("CHE_DataMovimento", TypeName = "smalldatetime")]
    public DateTime? CheDataMovimento { get; set; }

    [Column("CHE_DataBase", TypeName = "smalldatetime")]
    public DateTime? CheDataBase { get; set; }

    [Column("CHE_DataVencimento", TypeName = "smalldatetime")]
    public DateTime? CheDataVencimento { get; set; }

    [Column("CHE_Valor", TypeName = "decimal(15, 3)")]
    public decimal? CheValor { get; set; }

    [Column("CHE_Observacao")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CheObservacao { get; set; }

    [Column("SAC_Codigo")]
    public int SacCodigo { get; set; }

    [Column("PES_Codigo")]
    public int? PesCodigo { get; set; }

    [Column("VDA_Codigo")]
    public long VdaCodigo { get; set; }

    [Column("USR_Codigo")]
    public short UsrCodigo { get; set; }

    [Column("STS_Codigo")]
    public short? StsCodigo { get; set; }

    [ForeignKey("PesCodigo")]
    [InverseProperty("Cheques")]
    public virtual Pessoa? PesCodigoNavigation { get; set; }

    [ForeignKey("SacCodigo")]
    [InverseProperty("Cheques")]
    public virtual ChequeSacado SacCodigoNavigation { get; set; } = null!;

    [ForeignKey("StsCodigo")]
    [InverseProperty("Cheques")]
    public virtual ChequeStatus? StsCodigoNavigation { get; set; }

    [ForeignKey("UsrCodigo")]
    [InverseProperty("Cheques")]
    public virtual Usuario UsrCodigoNavigation { get; set; } = null!;

    [ForeignKey("VdaCodigo")]
    [InverseProperty("Cheques")]
    public virtual Vendum VdaCodigoNavigation { get; set; } = null!;
}
