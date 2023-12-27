using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("CTE_TOMADOR_naoUsar")]
public partial class CteTomadorNaoUsar
{
    [Key]
    [Column("TOM_Codigo")]
    public short TomCodigo { get; set; }

    [Column("TOM_Razao")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TomRazao { get; set; }

    [Column("TOM_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string TomDescricao { get; set; } = null!;

    [Column("TOM_Cnpj")]
    [StringLength(15)]
    [Unicode(false)]
    public string TomCnpj { get; set; } = null!;

    [Column("TOM_Logradouro")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TomLogradouro { get; set; }

    [Column("TOM_Municipio")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TomMunicipio { get; set; }

    [Column("TOM_Bairro")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TomBairro { get; set; }

    [Column("TOM_UF")]
    [StringLength(3)]
    [Unicode(false)]
    public string? TomUf { get; set; }

    [Column("TOM_CEP")]
    [StringLength(9)]
    [Unicode(false)]
    public string? TomCep { get; set; }

    [Column("TOM_Fone")]
    [StringLength(15)]
    [Unicode(false)]
    public string? TomFone { get; set; }

    [Column("TOM_Fax")]
    [StringLength(15)]
    [Unicode(false)]
    public string? TomFax { get; set; }

    [Column("TOM_NumeroLogradouro")]
    [StringLength(5)]
    [Unicode(false)]
    public string? TomNumeroLogradouro { get; set; }

    [Column("TOM_Complemento")]
    [StringLength(22)]
    [Unicode(false)]
    public string? TomComplemento { get; set; }

    [Column("TOM_Contato")]
    [StringLength(18)]
    [Unicode(false)]
    public string? TomContato { get; set; }

    [Column("TOM_InscricaoEstadual")]
    [StringLength(20)]
    [Unicode(false)]
    public string? TomInscricaoEstadual { get; set; }

    [Column("TOM_DadosAdicionais")]
    [StringLength(500)]
    [Unicode(false)]
    public string? TomDadosAdicionais { get; set; }

    [Column("TOM_EmailEmpresa")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TomEmailEmpresa { get; set; }
}
