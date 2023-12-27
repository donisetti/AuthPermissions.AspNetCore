using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Keyless]
public partial class Cliente
{
    [Column("fisJur")]
    [StringLength(1)]
    [Unicode(false)]
    public string FisJur { get; set; } = null!;

    [Column("id")]
    public int Id { get; set; }

    [Column("RAZAO_SOCIAL")]
    [StringLength(100)]
    [Unicode(false)]
    public string? RazaoSocial { get; set; }

    [Column("CPF_CNPJ")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CpfCnpj { get; set; }

    [Column("INSCRICAO_ESTADUAL")]
    public int? InscricaoEstadual { get; set; }

    [Column("CODIGO_MUNICIPIO")]
    [StringLength(40)]
    [Unicode(false)]
    public string? CodigoMunicipio { get; set; }

    [Column("SUFRAMA")]
    public int? Suframa { get; set; }

    [Column("LOGRADOURO")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Logradouro { get; set; }

    [Column("NUMERO")]
    [StringLength(8)]
    [Unicode(false)]
    public string? Numero { get; set; }

    [Column("COMPLEMENTO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Complemento { get; set; }

    [Column("BAIRRO")]
    [StringLength(80)]
    [Unicode(false)]
    public string? Bairro { get; set; }
}
