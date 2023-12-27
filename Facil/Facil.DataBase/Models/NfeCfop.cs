using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("NFe_CFOP")]
public partial class NfeCfop
{
    [Key]
    [Column("CFOP_Codigo")]
    [StringLength(4)]
    [Unicode(false)]
    public string CfopCodigo { get; set; } = null!;

    [Column("CFOP_Descricao")]
    [StringLength(255)]
    [Unicode(false)]
    public string CfopDescricao { get; set; } = null!;

    [Column("CFOP_PermitidoVenda")]
    public bool? CfopPermitidoVenda { get; set; }

    [InverseProperty("CfopNfFornecedorNavigation")]
    public virtual NfeCfopCorrespondencium? NfeCfopCorrespondencium { get; set; }
}
