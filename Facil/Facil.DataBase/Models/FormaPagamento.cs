using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("FORMA_PAGAMENTO")]
public partial class FormaPagamento
{
    [Key]
    [Column("FPG_Codigo")]
    public short FpgCodigo { get; set; }

    [Column("FPG_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string FpgDescricao { get; set; } = null!;

    [Column("PCT_CodigoReduzido")]
    public int? PctCodigoReduzido { get; set; }

    [Column("FPG_Carregar")]
    public bool? FpgCarregar { get; set; }

    [InverseProperty("FpgCodigoNavigation")]
    public virtual ICollection<FormaPagamentoImpressora> FormaPagamentoImpressoras { get; set; } = new List<FormaPagamentoImpressora>();

    [ForeignKey("PctCodigoReduzido")]
    [InverseProperty("FormaPagamentos")]
    public virtual PlanoConta? PctCodigoReduzidoNavigation { get; set; }
}
