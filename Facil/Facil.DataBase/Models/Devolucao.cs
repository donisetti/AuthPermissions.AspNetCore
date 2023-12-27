using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("DEVOLUCAO")]
public partial class Devolucao
{
    [Key]
    [Column("DEV_Codigo")]
    public int DevCodigo { get; set; }

    [Column("DEV_DataMovimento", TypeName = "smalldatetime")]
    public DateTime? DevDataMovimento { get; set; }

    [Column("DEV_DataFechamento", TypeName = "smalldatetime")]
    public DateTime? DevDataFechamento { get; set; }

    [Column("DEV_ValorDevolucao", TypeName = "decimal(15, 2)")]
    public decimal? DevValorDevolucao { get; set; }

    [Column("USU_Codigo_movimento")]
    public short? UsuCodigoMovimento { get; set; }

    [Column("USU_Codigo_Fechamento")]
    public short? UsuCodigoFechamento { get; set; }

    [Column("PES_Codigo")]
    public int? PesCodigo { get; set; }

    [Column("EMP_Codigo")]
    public short? EmpCodigo { get; set; }

    [Column("VDA_Codigo")]
    public long? VdaCodigo { get; set; }

    [InverseProperty("DevCodigoNavigation")]
    public virtual ICollection<DevolucaoItem> DevolucaoItems { get; set; } = new List<DevolucaoItem>();

    [ForeignKey("EmpCodigo")]
    [InverseProperty("Devolucaos")]
    public virtual EmpresasGrupo? EmpCodigoNavigation { get; set; }

    [ForeignKey("PesCodigo")]
    [InverseProperty("Devolucaos")]
    public virtual Pessoa? PesCodigoNavigation { get; set; }

    [ForeignKey("UsuCodigoMovimento")]
    [InverseProperty("Devolucaos")]
    public virtual Usuario? UsuCodigoMovimentoNavigation { get; set; }

    [ForeignKey("VdaCodigo")]
    [InverseProperty("Devolucaos")]
    public virtual Vendum? VdaCodigoNavigation { get; set; }
}
