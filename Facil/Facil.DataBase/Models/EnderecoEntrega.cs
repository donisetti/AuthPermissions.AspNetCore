using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("ENDERECO_ENTREGA")]
public partial class EnderecoEntrega
{
    [Key]
    [Column("ETG_Codigo")]
    public int EtgCodigo { get; set; }

    [Column("PES_Codigo")]
    public int PesCodigo { get; set; }

    [Column("ETG_Endereco")]
    [StringLength(100)]
    [Unicode(false)]
    public string EtgEndereco { get; set; } = null!;

    [Column("ETG_Complemento")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EtgComplemento { get; set; }

    [Column("ETG_Bairro")]
    [StringLength(80)]
    [Unicode(false)]
    public string? EtgBairro { get; set; }

    [Column("ETG_Cidade")]
    [StringLength(40)]
    [Unicode(false)]
    public string? EtgCidade { get; set; }

    [Column("ETG_Cep")]
    [StringLength(9)]
    [Unicode(false)]
    public string? EtgCep { get; set; }

    [Column("ETG_Uf")]
    [StringLength(3)]
    [Unicode(false)]
    public string? EtgUf { get; set; }

    [Column("ETG_EntregarNeste")]
    public bool? EtgEntregarNeste { get; set; }

    [Column("VDA_Codigo")]
    public long? VdaCodigo { get; set; }

    [Column("VDA_NomeCliente")]
    [StringLength(50)]
    [Unicode(false)]
    public string? VdaNomeCliente { get; set; }

    [Column("ETG_Fone")]
    [StringLength(15)]
    [Unicode(false)]
    public string? EtgFone { get; set; }

    [ForeignKey("PesCodigo")]
    [InverseProperty("EnderecoEntregas")]
    public virtual Pessoa PesCodigoNavigation { get; set; } = null!;

    [ForeignKey("VdaCodigo")]
    [InverseProperty("EnderecoEntregas")]
    public virtual Vendum? VdaCodigoNavigation { get; set; }
}
