using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("SAIDA_PRODUTOS")]
public partial class SaidaProduto
{
    [Key]
    [Column("SPR_Codigo")]
    public int SprCodigo { get; set; }

    [Column("SPR_DataVenda", TypeName = "smalldatetime")]
    public DateTime SprDataVenda { get; set; }

    [Column("SPR_NumeroReceita")]
    [StringLength(20)]
    [Unicode(false)]
    public string SprNumeroReceita { get; set; } = null!;

    [Column("SPR_DataReceita", TypeName = "smalldatetime")]
    public DateTime SprDataReceita { get; set; }

    [Column("SPR_NumeroLote")]
    [StringLength(30)]
    [Unicode(false)]
    public string SprNumeroLote { get; set; } = null!;

    [Column("SPR_Quantidade")]
    public short SprQuantidade { get; set; }

    [Column("PRO_Codigo")]
    public int ProCodigo { get; set; }

    [Column("TUM_Codigo")]
    public short TumCodigo { get; set; }

    [Column("TDO_Codigo")]
    public short TdoCodigo { get; set; }

    [Column("MED_Codigo")]
    public int MedCodigo { get; set; }

    [Column("TIO_Codigo")]
    public short TioCodigo { get; set; }

    [Column("PCLI_Codigo")]
    public int PcliCodigo { get; set; }

    [Column("SPR_DataEnvio", TypeName = "smalldatetime")]
    public DateTime SprDataEnvio { get; set; }

    [Column("SPR_DataMovimentacao", TypeName = "smalldatetime")]
    public DateTime SprDataMovimentacao { get; set; }

    [Column("PRO_RegistroMsInventario")]
    [StringLength(13)]
    [Unicode(false)]
    public string? ProRegistroMsInventario { get; set; }

    [Column("SPR_UsoProlongado")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SprUsoProlongado { get; set; }

    [ForeignKey("MedCodigo")]
    [InverseProperty("SaidaProdutos")]
    public virtual Medico MedCodigoNavigation { get; set; } = null!;

    [ForeignKey("PcliCodigo")]
    [InverseProperty("SaidaProdutos")]
    public virtual PsicoCliente PcliCodigoNavigation { get; set; } = null!;

    [ForeignKey("ProCodigo")]
    [InverseProperty("SaidaProdutos")]
    public virtual Produto ProCodigoNavigation { get; set; } = null!;

    [ForeignKey("TdoCodigo")]
    [InverseProperty("SaidaProdutos")]
    public virtual TipoDocumento TdoCodigoNavigation { get; set; } = null!;

    [ForeignKey("TioCodigo")]
    [InverseProperty("SaidaProdutos")]
    public virtual TipoReceituario TioCodigoNavigation { get; set; } = null!;

    [ForeignKey("TumCodigo")]
    [InverseProperty("SaidaProdutos")]
    public virtual TipoUsoMedicamento TumCodigoNavigation { get; set; } = null!;
}
