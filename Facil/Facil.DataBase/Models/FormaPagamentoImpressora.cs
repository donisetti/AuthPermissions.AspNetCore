using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("FORMA_PAGAMENTO_IMPRESSORA")]
public partial class FormaPagamentoImpressora
{
    [Key]
    [Column("FPI_Codigo")]
    public short FpiCodigo { get; set; }

    [Column("BAK_Codigo")]
    public short? BakCodigo { get; set; }

    [Column("FPG_Codigo")]
    public short? FpgCodigo { get; set; }

    [Column("IMP_Codigo")]
    public short? ImpCodigo { get; set; }

    [Column("FPG_Codigo_ImpFiscal")]
    public short? FpgCodigoImpFiscal { get; set; }

    [ForeignKey("BakCodigo")]
    [InverseProperty("FormaPagamentoImpressoras")]
    public virtual Backup? BakCodigoNavigation { get; set; }

    [ForeignKey("FpgCodigo")]
    [InverseProperty("FormaPagamentoImpressoras")]
    public virtual FormaPagamento? FpgCodigoNavigation { get; set; }

    [ForeignKey("ImpCodigo")]
    [InverseProperty("FormaPagamentoImpressoras")]
    public virtual Impressora? ImpCodigoNavigation { get; set; }
}
