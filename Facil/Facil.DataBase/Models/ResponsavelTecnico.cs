using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("RESPONSAVEL_TECNICO")]
public partial class ResponsavelTecnico
{
    [Key]
    [Column("RTE_Cpf")]
    public long RteCpf { get; set; }

    [Column("RTE_Email")]
    [StringLength(100)]
    [Unicode(false)]
    public string RteEmail { get; set; } = null!;

    [Column("RTE_Senha")]
    [StringLength(20)]
    [Unicode(false)]
    public string RteSenha { get; set; } = null!;

    [Column("RTE_CRF")]
    [StringLength(15)]
    [Unicode(false)]
    public string? RteCrf { get; set; }

    [Column("RTE_DataEmissao", TypeName = "smalldatetime")]
    public DateTime? RteDataEmissao { get; set; }

    [Column("RTE_CRFEstado")]
    [StringLength(2)]
    [Unicode(false)]
    public string? RteCrfestado { get; set; }

    [Column("RTE_Nome")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RteNome { get; set; }
}
