using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("TRANSFERENCIA_PRODUTOS")]
public partial class TransferenciaProduto
{
    [Key]
    [Column("TPR_Codigo")]
    public int TprCodigo { get; set; }

    [Column("TPR_DataNF", TypeName = "smalldatetime")]
    public DateTime TprDataNf { get; set; }

    [Column("TPR_NumeroNF")]
    [StringLength(10)]
    [Unicode(false)]
    public string TprNumeroNf { get; set; } = null!;

    [Column("FOR_CodigoOrigem")]
    public int ForCodigoOrigem { get; set; }

    [Column("FOR_CodigoDestino")]
    public int ForCodigoDestino { get; set; }

    [Column("TPR_Quantidade")]
    public short TprQuantidade { get; set; }

    [Column("TPR_DataTransferencia", TypeName = "smalldatetime")]
    public DateTime TprDataTransferencia { get; set; }

    [Column("TPR_NumeroLote")]
    [StringLength(30)]
    [Unicode(false)]
    public string TprNumeroLote { get; set; } = null!;

    [Column("PRO_Codigo")]
    public int ProCodigo { get; set; }

    [Column("TNF_Codigo")]
    public short TnfCodigo { get; set; }

    [Column("TPR_DataEnvio", TypeName = "smalldatetime")]
    public DateTime TprDataEnvio { get; set; }

    [Column("TPR_DataMovimentacao", TypeName = "smalldatetime")]
    public DateTime TprDataMovimentacao { get; set; }

    [ForeignKey("ProCodigo")]
    [InverseProperty("TransferenciaProdutos")]
    public virtual Produto ProCodigoNavigation { get; set; } = null!;

    [ForeignKey("TnfCodigo")]
    [InverseProperty("TransferenciaProdutos")]
    public virtual TipoNotafiscal TnfCodigoNavigation { get; set; } = null!;
}
