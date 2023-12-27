using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PET_PACIENTE")]
public partial class PetPaciente
{
    [Key]
    [Column("PAC_Codigo")]
    public int PacCodigo { get; set; }

    [Column("PAC_Nome")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PacNome { get; set; }

    [Column("PEL_Codigo")]
    public short PelCodigo { get; set; }

    [Column("PAC_Descricao")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PacDescricao { get; set; }

    [Column("PAC_Sexo")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PacSexo { get; set; }

    [Column("PAC_DataNascimento", TypeName = "smalldatetime")]
    public DateTime? PacDataNascimento { get; set; }

    [Column("PAC_Idade")]
    [StringLength(30)]
    [Unicode(false)]
    public string? PacIdade { get; set; }

    [Column("PAC_Foto")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PacFoto { get; set; }

    [Column("PES_Codigo")]
    public int? PesCodigo { get; set; }

    [Column("ESP_Codigo")]
    public short? EspCodigo { get; set; }

    [Column("RAC_Codigo")]
    public short? RacCodigo { get; set; }

    [Column("PAC_DataExclusao", TypeName = "smalldatetime")]
    public DateTime? PacDataExclusao { get; set; }

    [InverseProperty("PacCodigoNavigation")]
    public virtual ICollection<PetAgendum> PetAgenda { get; set; } = new List<PetAgendum>();

    [InverseProperty("PacCodigoNavigation")]
    public virtual ICollection<PetConsultum> PetConsulta { get; set; } = new List<PetConsultum>();

    [InverseProperty("PacCodigoNavigation")]
    public virtual ICollection<PetVacinacao> PetVacinacaos { get; set; } = new List<PetVacinacao>();
}
