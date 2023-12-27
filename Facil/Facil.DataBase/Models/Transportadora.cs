using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("TRANSPORTADORAS")]
public partial class Transportadora
{
    [Key]
    [Column("TRA_Codigo")]
    public short TraCodigo { get; set; }

    [Column("TRA_RazaoSocial")]
    [StringLength(50)]
    [Unicode(false)]
    public string TraRazaoSocial { get; set; } = null!;

    [Column("TRA_Fantasia")]
    [StringLength(50)]
    [Unicode(false)]
    public string TraFantasia { get; set; } = null!;

    [Column("TRA_Cnpj")]
    [StringLength(15)]
    [Unicode(false)]
    public string TraCnpj { get; set; } = null!;

    [Column("TRA_InscricaoEstadual")]
    [StringLength(15)]
    [Unicode(false)]
    public string? TraInscricaoEstadual { get; set; }

    [Column("TRA_Endereco")]
    [StringLength(50)]
    [Unicode(false)]
    public string TraEndereco { get; set; } = null!;

    [Column("TRA_Numero")]
    [StringLength(5)]
    [Unicode(false)]
    public string TraNumero { get; set; } = null!;

    [Column("TRA_Complemento")]
    [StringLength(22)]
    [Unicode(false)]
    public string? TraComplemento { get; set; }

    [Column("TRA_Cidade")]
    [StringLength(50)]
    [Unicode(false)]
    public string TraCidade { get; set; } = null!;

    [Column("TRA_Bairro")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TraBairro { get; set; }

    [Column("TRA_UF")]
    [StringLength(3)]
    [Unicode(false)]
    public string TraUf { get; set; } = null!;

    [Column("TRA_CEP")]
    [StringLength(9)]
    [Unicode(false)]
    public string? TraCep { get; set; }

    [Column("TRA_Fone1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? TraFone1 { get; set; }

    [Column("TRA_Fone2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? TraFone2 { get; set; }

    [Column("TRA_Contato")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TraContato { get; set; }
}
