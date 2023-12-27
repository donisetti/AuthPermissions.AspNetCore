using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("FISICA")]
public partial class Fisica
{
    [Key]
    [Column("PES_Codigo")]
    public int PesCodigo { get; set; }

    [Column("FIS_Nome")]
    [StringLength(100)]
    [Unicode(false)]
    public string FisNome { get; set; } = null!;

    [Column("FIS_Rg")]
    [StringLength(20)]
    [Unicode(false)]
    public string? FisRg { get; set; }

    [Column("FIS_Cpf")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FisCpf { get; set; }

    [Column("FIS_NomeMae")]
    [StringLength(100)]
    [Unicode(false)]
    public string? FisNomeMae { get; set; }

    [Column("FIS_Sexo")]
    [StringLength(1)]
    [Unicode(false)]
    public string? FisSexo { get; set; }

    [Column("FIS_OrgaoEmissor")]
    [StringLength(8)]
    [Unicode(false)]
    public string? FisOrgaoEmissor { get; set; }

    [Column("FIS_Dta_Nascimento", TypeName = "smalldatetime")]
    public DateTime? FisDtaNascimento { get; set; }

    [Column("FIS_EnderecoComercial")]
    [StringLength(100)]
    [Unicode(false)]
    public string? FisEnderecoComercial { get; set; }

    [Column("FIS_LocalTrabalho")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FisLocalTrabalho { get; set; }

    [Column("FIS_FoneComercial")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FisFoneComercial { get; set; }

    [Column("FIS_FoneReferenciaComercial")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FisFoneReferenciaComercial { get; set; }

    [Column("FIS_NomePai")]
    [StringLength(100)]
    [Unicode(false)]
    public string? FisNomePai { get; set; }

    [Column("FIS_ReferenciaCom")]
    [StringLength(100)]
    [Unicode(false)]
    public string? FisReferenciaCom { get; set; }

    [Column("FIS_CidadeLocalTrabalho")]
    [StringLength(40)]
    [Unicode(false)]
    public string? FisCidadeLocalTrabalho { get; set; }

    [Column("FIS_SalarioLocalTrabalho", TypeName = "decimal(10, 2)")]
    public decimal? FisSalarioLocalTrabalho { get; set; }

    [Column("FIS_TempoServico")]
    [StringLength(30)]
    [Unicode(false)]
    public string? FisTempoServico { get; set; }

    [Column("Fis_EstadoCivil")]
    [StringLength(20)]
    [Unicode(false)]
    public string? FisEstadoCivil { get; set; }

    [Column("FIS_Residencia")]
    [StringLength(20)]
    [Unicode(false)]
    public string? FisResidencia { get; set; }

    [Column("FIS_NomeConjuge")]
    [StringLength(100)]
    [Unicode(false)]
    public string? FisNomeConjuge { get; set; }

    [Column("FIS_DataNascimentoConjuge", TypeName = "smalldatetime")]
    public DateTime? FisDataNascimentoConjuge { get; set; }

    [Column("FIS_LocalTrabalhoConjuge")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FisLocalTrabalhoConjuge { get; set; }

    [Column("FIS_EnderecoLocalTrabalhoConjuge")]
    [StringLength(100)]
    [Unicode(false)]
    public string? FisEnderecoLocalTrabalhoConjuge { get; set; }

    [Column("FIS_CidadeLocalTrabalhoConjuge")]
    [StringLength(40)]
    [Unicode(false)]
    public string? FisCidadeLocalTrabalhoConjuge { get; set; }

    [Column("FIS_FoneLocalTrabalhoConjuge")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FisFoneLocalTrabalhoConjuge { get; set; }

    [Column("FIS_SalarioConjuge", TypeName = "decimal(10, 2)")]
    public decimal? FisSalarioConjuge { get; set; }

    [Column("FIS_TempoServicoConjuge")]
    [StringLength(30)]
    [Unicode(false)]
    public string? FisTempoServicoConjuge { get; set; }

    [Column("FIS_FuncaoTrabalho")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FisFuncaoTrabalho { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastEditDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("FIS_Natural")]
    [StringLength(30)]
    [Unicode(false)]
    public string? FisNatural { get; set; }

    [Column("FIS_IEProdutorRural")]
    [StringLength(20)]
    [Unicode(false)]
    public string? FisIeprodutorRural { get; set; }

    [ForeignKey("PesCodigo")]
    [InverseProperty("Fisica")]
    public virtual Pessoa PesCodigoNavigation { get; set; } = null!;

    [InverseProperty("CliCodigoNavigation")]
    public virtual ICollection<SaidaInsumo> SaidaInsumos { get; set; } = new List<SaidaInsumo>();
}
