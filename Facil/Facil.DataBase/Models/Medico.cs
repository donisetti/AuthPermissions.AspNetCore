using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("MEDICOS")]
public partial class Medico
{
    [Key]
    [Column("MED_Codigo")]
    public int MedCodigo { get; set; }

    [Column("MED_DataCadastro", TypeName = "smalldatetime")]
    public DateTime MedDataCadastro { get; set; }

    [Column("MED_Nome")]
    [StringLength(50)]
    [Unicode(false)]
    public string MedNome { get; set; } = null!;

    [Column("MED_Numero_Registro")]
    [StringLength(10)]
    [Unicode(false)]
    public string MedNumeroRegistro { get; set; } = null!;

    [Column("CAL_Sigla")]
    [StringLength(20)]
    [Unicode(false)]
    public string CalSigla { get; set; } = null!;

    [Column("EST_Sigla")]
    [StringLength(2)]
    [Unicode(false)]
    public string EstSigla { get; set; } = null!;

    [ForeignKey("CalSigla")]
    [InverseProperty("Medicos")]
    public virtual ConselhoProfissional CalSiglaNavigation { get; set; } = null!;

    [InverseProperty("MedCodigoNavigation")]
    public virtual ICollection<CopsMovimento> CopsMovimentos { get; set; } = new List<CopsMovimento>();

    [InverseProperty("MedCodigoNavigation")]
    public virtual ICollection<SaidaInsumo> SaidaInsumos { get; set; } = new List<SaidaInsumo>();

    [InverseProperty("MedCodigoNavigation")]
    public virtual ICollection<SaidaProduto> SaidaProdutos { get; set; } = new List<SaidaProduto>();
}
