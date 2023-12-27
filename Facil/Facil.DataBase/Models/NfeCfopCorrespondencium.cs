using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("NFe_CFOP_CORRESPONDENCIA")]
public partial class NfeCfopCorrespondencium
{
    [Key]
    [Column("CFOP_NF_Fornecedor")]
    [StringLength(4)]
    [Unicode(false)]
    public string CfopNfFornecedor { get; set; } = null!;

    [Column("CFOP_Entrada")]
    [StringLength(4)]
    [Unicode(false)]
    public string CfopEntrada { get; set; } = null!;

    [Column("CFOP_Saida")]
    [StringLength(4)]
    [Unicode(false)]
    public string CfopSaida { get; set; } = null!;

    [ForeignKey("CfopNfFornecedor")]
    [InverseProperty("NfeCfopCorrespondencium")]
    public virtual NfeCfop CfopNfFornecedorNavigation { get; set; } = null!;
}
