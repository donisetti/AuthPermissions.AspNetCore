using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PERDA_PRODUTOS")]
public partial class PerdaProduto
{
    [Key]
    [Column("PPR_Codigo")]
    public int PprCodigo { get; set; }

    [Column("PPR_NumeroLote")]
    [StringLength(30)]
    [Unicode(false)]
    public string PprNumeroLote { get; set; } = null!;

    [Column("PPR_Quantidade")]
    public short PprQuantidade { get; set; }

    [Column("PPR_DataPerda", TypeName = "smalldatetime")]
    public DateTime PprDataPerda { get; set; }

    [Column("TMP_Codigo")]
    public short TmpCodigo { get; set; }

    [Column("PRO_Codigo")]
    public int ProCodigo { get; set; }

    [Column("PPR_DataEnvio", TypeName = "smalldatetime")]
    public DateTime PprDataEnvio { get; set; }

    [Column("PPR_DataMovimentacao", TypeName = "smalldatetime")]
    public DateTime PprDataMovimentacao { get; set; }

    [Column("PRO_RegistroMsInventario")]
    [StringLength(13)]
    [Unicode(false)]
    public string? ProRegistroMsInventario { get; set; }

    [ForeignKey("ProCodigo")]
    [InverseProperty("PerdaProdutos")]
    public virtual Produto ProCodigoNavigation { get; set; } = null!;

    [ForeignKey("TmpCodigo")]
    [InverseProperty("PerdaProdutos")]
    public virtual TipoMotivoPerdum TmpCodigoNavigation { get; set; } = null!;
}
