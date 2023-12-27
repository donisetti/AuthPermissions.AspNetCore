using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("ENTRADA")]
public partial class Entradum
{
    [Key]
    [Column("ENT_Codigo")]
    public int EntCodigo { get; set; }

    [Column("ENT_DataEntrada", TypeName = "smalldatetime")]
    public DateTime EntDataEntrada { get; set; }

    [Column("ENT_DataEncerramento", TypeName = "smalldatetime")]
    public DateTime? EntDataEncerramento { get; set; }

    [Column("ENT_NotaFiscal")]
    [StringLength(15)]
    [Unicode(false)]
    public string? EntNotaFiscal { get; set; }

    [Column("ENT_ValorNota", TypeName = "decimal(15, 2)")]
    public decimal? EntValorNota { get; set; }

    [Column("FOR_Codigo")]
    public int? ForCodigo { get; set; }

    [Column("ENT_DataNotaFiscal", TypeName = "smalldatetime")]
    public DateTime? EntDataNotaFiscal { get; set; }

    [Column("USU_Codigo")]
    public short? UsuCodigo { get; set; }

    [Column("EMP_Codigo")]
    public short? EmpCodigo { get; set; }

    [Column("ENT_ValorIpiEntrada", TypeName = "decimal(15, 2)")]
    public decimal? EntValorIpiEntrada { get; set; }

    [Column("ENT_ValorFrete", TypeName = "decimal(15, 2)")]
    public decimal? EntValorFrete { get; set; }

    [Column("ENT_ValorSubEntrada", TypeName = "decimal(15, 2)")]
    public decimal? EntValorSubEntrada { get; set; }

    [Column("ENT_ValorProdutos", TypeName = "decimal(15, 2)")]
    public decimal? EntValorProdutos { get; set; }

    [Column("ENT_ChNFe")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EntChNfe { get; set; }

    [Column("ENT_ValorSeguro", TypeName = "decimal(15, 2)")]
    public decimal? EntValorSeguro { get; set; }

    [Column("ENT_ValorDesconto", TypeName = "decimal(15, 2)")]
    public decimal? EntValorDesconto { get; set; }

    [Column("ENT_Serie")]
    [StringLength(3)]
    [Unicode(false)]
    public string? EntSerie { get; set; }

    [Column("ENT_DataImportacao", TypeName = "smalldatetime")]
    public DateTime? EntDataImportacao { get; set; }

    [Column("ENT_AproveitarICMS")]
    public bool? EntAproveitarIcms { get; set; }

    [Column("ENT_Xml", TypeName = "text")]
    public string? EntXml { get; set; }

    [InverseProperty("EntCodigoNavigation")]
    public virtual ICollection<EntradaItem> EntradaItems { get; set; } = new List<EntradaItem>();

    [ForeignKey("UsuCodigo")]
    [InverseProperty("Entrada")]
    public virtual Usuario? UsuCodigoNavigation { get; set; }
}
