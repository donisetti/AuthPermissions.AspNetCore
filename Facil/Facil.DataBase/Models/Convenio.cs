using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("CONVENIO")]
public partial class Convenio
{
    [Key]
    [Column("CVN_Codigo")]
    public short CvnCodigo { get; set; }

    [Column("CVN_Descricao")]
    [StringLength(40)]
    [Unicode(false)]
    public string CvnDescricao { get; set; } = null!;

    [Column("CVN_PctDesconto", TypeName = "decimal(5, 2)")]
    public decimal? CvnPctDesconto { get; set; }

    [Column("CVN_CobrarJuros")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CvnCobrarJuros { get; set; }

    [Column("CVN_LimiteCredito", TypeName = "decimal(15, 2)")]
    public decimal? CvnLimiteCredito { get; set; }

    [Column("CVN_Endereco")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CvnEndereco { get; set; }

    [Column("CVN_Complemento")]
    [StringLength(30)]
    [Unicode(false)]
    public string? CvnComplemento { get; set; }

    [Column("CVN_Numero")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CvnNumero { get; set; }

    [Column("CVN_Bairro")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CvnBairro { get; set; }

    [Column("CVN_Fone")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CvnFone { get; set; }

    [Column("CVN_DataCadastro", TypeName = "smalldatetime")]
    public DateTime? CvnDataCadastro { get; set; }

    [Column("CVN_Bloqueado")]
    public bool? CvnBloqueado { get; set; }

    [Column("CVN_Municipio")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CvnMunicipio { get; set; }

    [Column("CVN_UF")]
    [StringLength(3)]
    [Unicode(false)]
    public string? CvnUf { get; set; }

    [Column("CVN_CEP")]
    [StringLength(9)]
    [Unicode(false)]
    public string? CvnCep { get; set; }

    [Column("CVN_Contato")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CvnContato { get; set; }

    [Column("CVN_Observacao")]
    [StringLength(150)]
    [Unicode(false)]
    public string? CvnObservacao { get; set; }

    [Column("CVN_Email")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CvnEmail { get; set; }

    [Column("CVN_CNPJ")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CvnCnpj { get; set; }

    [Column("CVN_DataExclusao", TypeName = "smalldatetime")]
    public DateTime? CvnDataExclusao { get; set; }

    [InverseProperty("CvnCodigoNavigation")]
    public virtual ICollection<Pessoa> Pessoas { get; set; } = new List<Pessoa>();
}
