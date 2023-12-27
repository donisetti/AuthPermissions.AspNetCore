using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[PrimaryKey("PedCodigo", "VenCodigo")]
[Table("PEDIDO_APP")]
public partial class PedidoApp
{
    [Key]
    [Column("PED_Codigo")]
    public int PedCodigo { get; set; }

    [Key]
    [Column("VEN_Codigo")]
    public int VenCodigo { get; set; }

    [Column("VEN_Nome")]
    [StringLength(60)]
    [Unicode(false)]
    public string? VenNome { get; set; }

    [Column("PED_Data", TypeName = "smalldatetime")]
    public DateTime PedData { get; set; }

    [Column("CLI_Codigo")]
    public int CliCodigo { get; set; }

    [Column("CLI_Nome")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CliNome { get; set; }

    [Column("PAG_Codigo")]
    public int PagCodigo { get; set; }

    [Column("VDA_Codigo")]
    public int? VdaCodigo { get; set; }

    [Column("PED_ValorFinal", TypeName = "decimal(15, 3)")]
    public decimal PedValorFinal { get; set; }

    [Column("PED_ValorDesconto", TypeName = "decimal(15, 3)")]
    public decimal PedValorDesconto { get; set; }

    [Column("PED_Observacao")]
    [StringLength(150)]
    [Unicode(false)]
    public string? PedObservacao { get; set; }

    [Column("PED_DataEstorno", TypeName = "smalldatetime")]
    public DateTime? PedDataEstorno { get; set; }

    [Column("PED_UsuarioEstorno")]
    public short? PedUsuarioEstorno { get; set; }
}
