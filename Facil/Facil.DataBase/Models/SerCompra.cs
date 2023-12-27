using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("SER_COMPRA")]
public partial class SerCompra
{
    [Key]
    [Column("COM_Codigo")]
    public int ComCodigo { get; set; }

    [Column("COM_DataLancamento", TypeName = "smalldatetime")]
    public DateTime? ComDataLancamento { get; set; }

    [Column("COM_DataFechamento", TypeName = "smalldatetime")]
    public DateTime? ComDataFechamento { get; set; }

    [Column("PES_Codigo")]
    public int? PesCodigo { get; set; }

    [Column("FOR_Codigo")]
    public int? ForCodigo { get; set; }

    [Column("USR_Codigo")]
    public short? UsrCodigo { get; set; }

    [ForeignKey("ForCodigo")]
    [InverseProperty("SerCompras")]
    public virtual Fornecedore? ForCodigoNavigation { get; set; }

    [ForeignKey("PesCodigo")]
    [InverseProperty("SerCompras")]
    public virtual Pessoa? PesCodigoNavigation { get; set; }

    [InverseProperty("ComCodigoNavigation")]
    public virtual ICollection<SerCompraItem> SerCompraItems { get; set; } = new List<SerCompraItem>();

    [ForeignKey("UsrCodigo")]
    [InverseProperty("SerCompras")]
    public virtual Usuario? UsrCodigoNavigation { get; set; }
}
