using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("CONSIGNADO")]
public partial class Consignado
{
    [Key]
    [Column("CDO_Codigo")]
    public long CdoCodigo { get; set; }

    [Column("CDO_DataLancamento", TypeName = "datetime")]
    public DateTime CdoDataLancamento { get; set; }

    [Column("CDO_Valor", TypeName = "decimal(15, 2)")]
    public decimal CdoValor { get; set; }

    [Column("CDO_DataEstorno", TypeName = "smalldatetime")]
    public DateTime? CdoDataEstorno { get; set; }

    [Column("CDO_UsuarioEstorno")]
    public short? CdoUsuarioEstorno { get; set; }

    [Column("Vda_Vendedor")]
    public short VdaVendedor { get; set; }

    [Column("PES_Codigo")]
    public int PesCodigo { get; set; }

    [Column("CDO_DataFechamento", TypeName = "smalldatetime")]
    public DateTime? CdoDataFechamento { get; set; }

    [Column("USR_CodigoLiberouVenda")]
    public short? UsrCodigoLiberouVenda { get; set; }

    [ForeignKey("PesCodigo")]
    [InverseProperty("Consignados")]
    public virtual Pessoa PesCodigoNavigation { get; set; } = null!;
}
