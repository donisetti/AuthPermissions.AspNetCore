using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("RESTBAR_ENDERECO_ENTREGA")]
public partial class RestbarEnderecoEntrega
{
    [Key]
    [Column("RBE_CODIGO")]
    public short RbeCodigo { get; set; }

    [Column("RBP_CODIGO")]
    public short? RbpCodigo { get; set; }

    [Column("PES_CODIGO")]
    public short? PesCodigo { get; set; }

    [Column("PES_NOME")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PesNome { get; set; }

    [Column("RBE_ENDERECO")]
    [StringLength(100)]
    [Unicode(false)]
    public string? RbeEndereco { get; set; }

    [Column("RBE_NUMERO")]
    [StringLength(10)]
    [Unicode(false)]
    public string? RbeNumero { get; set; }

    [Column("RBE_BAIRRO")]
    [StringLength(100)]
    [Unicode(false)]
    public string? RbeBairro { get; set; }

    [Column("RBE_COMPLEMENTO")]
    [StringLength(200)]
    [Unicode(false)]
    public string? RbeComplemento { get; set; }

    [Column("RBE_OBSERVACAO")]
    [StringLength(250)]
    [Unicode(false)]
    public string? RbeObservacao { get; set; }

    [Column("RBE_TELEFONE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RbeTelefone { get; set; }

    [Column("RBE_CIDADE")]
    [StringLength(250)]
    [Unicode(false)]
    public string? RbeCidade { get; set; }

    [Column("RBE_TAXA_ENTREGA", TypeName = "decimal(12, 2)")]
    public decimal? RbeTaxaEntrega { get; set; }
}
