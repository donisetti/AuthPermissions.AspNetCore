using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("ENTRADA_PRODUTOS")]
public partial class EntradaProduto
{
    [Key]
    [Column("ENT_Codigo")]
    public int EntCodigo { get; set; }

    [Column("ENT_NumeroNF")]
    [StringLength(20)]
    [Unicode(false)]
    public string EntNumeroNf { get; set; } = null!;

    [Column("ENT_DataNF", TypeName = "smalldatetime")]
    public DateTime EntDataNf { get; set; }

    [Column("ENT_NumeroLote")]
    [StringLength(30)]
    [Unicode(false)]
    public string EntNumeroLote { get; set; } = null!;

    [Column("ENT_Quantidade")]
    public short EntQuantidade { get; set; }

    [Column("ENT_DataRecebimento", TypeName = "smalldatetime")]
    public DateTime EntDataRecebimento { get; set; }

    [Column("FOR_CodigoProduto")]
    public int ForCodigoProduto { get; set; }

    [Column("FOR_CodigoDestino")]
    public int ForCodigoDestino { get; set; }

    [Column("PRO_Codigo")]
    public int ProCodigo { get; set; }

    [Column("TNF_Codigo")]
    public short TnfCodigo { get; set; }

    [Column("ENT_DataEnvio", TypeName = "smalldatetime")]
    public DateTime EntDataEnvio { get; set; }

    [Column("ENT_DataMovimentacao", TypeName = "smalldatetime")]
    public DateTime EntDataMovimentacao { get; set; }

    [Column("PRO_RegistroMsInventario")]
    [StringLength(13)]
    [Unicode(false)]
    public string? ProRegistroMsInventario { get; set; }

    [ForeignKey("ForCodigoProduto")]
    [InverseProperty("EntradaProdutos")]
    public virtual Fornecedore ForCodigoProdutoNavigation { get; set; } = null!;

    [ForeignKey("ProCodigo")]
    [InverseProperty("EntradaProdutos")]
    public virtual Produto ProCodigoNavigation { get; set; } = null!;

    [ForeignKey("TnfCodigo")]
    [InverseProperty("EntradaProdutos")]
    public virtual TipoNotafiscal TnfCodigoNavigation { get; set; } = null!;
}
