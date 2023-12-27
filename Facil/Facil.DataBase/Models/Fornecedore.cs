using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("FORNECEDORES")]
public partial class Fornecedore
{
    [Key]
    [Column("FOR_Codigo")]
    public int ForCodigo { get; set; }

    [Column("FOR_DataCadastro", TypeName = "smalldatetime")]
    public DateTime? ForDataCadastro { get; set; }

    [Column("FOR_Nome")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ForNome { get; set; }

    [Column("FOR_Fantasia")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ForFantasia { get; set; }

    [Column("FOR_Rg_InscricaoEstadual")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ForRgInscricaoEstadual { get; set; }

    [Column("FOR_Cpf_Cnpj")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ForCpfCnpj { get; set; }

    [Column("FOR_Endereco")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ForEndereco { get; set; }

    [Column("FOR_Complemento")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ForComplemento { get; set; }

    [Column("FOR_Bairro")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ForBairro { get; set; }

    [Column("FOR_Cep")]
    [StringLength(9)]
    [Unicode(false)]
    public string? ForCep { get; set; }

    [Column("FOR_Cidade")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ForCidade { get; set; }

    [Column("FOR_Uf")]
    [StringLength(3)]
    [Unicode(false)]
    public string? ForUf { get; set; }

    [Column("FOR_Telefone")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ForTelefone { get; set; }

    [Column("FOR_Email")]
    [StringLength(150)]
    [Unicode(false)]
    public string? ForEmail { get; set; }

    [Column("FOR_Observacao")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ForObservacao { get; set; }

    [Column("FOR_TipoCadastro")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ForTipoCadastro { get; set; }

    [Column("PCT_CodigoReduzido")]
    public int? PctCodigoReduzido { get; set; }

    [Column("FOR_NumeroEndereco")]
    [StringLength(8)]
    [Unicode(false)]
    public string? ForNumeroEndereco { get; set; }

    [Column("FOR_Contato")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ForContato { get; set; }

    [Column("FOR_Fax")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ForFax { get; set; }

    [Column("FOR_Atividade")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ForAtividade { get; set; }

    [InverseProperty("ForCodigoProdutoNavigation")]
    public virtual ICollection<EntradaProduto> EntradaProdutos { get; set; } = new List<EntradaProduto>();

    [ForeignKey("PctCodigoReduzido")]
    [InverseProperty("Fornecedores")]
    public virtual PlanoConta? PctCodigoReduzidoNavigation { get; set; }

    [InverseProperty("ForCodigoNavigation")]
    public virtual ICollection<SerCompra> SerCompras { get; set; } = new List<SerCompra>();
}
