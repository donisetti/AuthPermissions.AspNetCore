using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("USUARIO")]
public partial class Usuario
{
    [Key]
    [Column("USR_Codigo")]
    public short UsrCodigo { get; set; }

    [Column("USR_Login")]
    [StringLength(20)]
    [Unicode(false)]
    public string UsrLogin { get; set; } = null!;

    [Column("USR_Senha")]
    [StringLength(15)]
    [Unicode(false)]
    public string? UsrSenha { get; set; }

    [Column("USR_Status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? UsrStatus { get; set; }

    [Column("USR_DtInclusao", TypeName = "smalldatetime")]
    public DateTime? UsrDtInclusao { get; set; }

    [Column("PES_Codigo")]
    public int PesCodigo { get; set; }

    [Column("FPO_LoginVendedorCPF")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FpoLoginVendedorCpf { get; set; }

    [Column("FPO_SenhaVendedor")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FpoSenhaVendedor { get; set; }

    [Column("USR_DtAlteracao", TypeName = "datetime")]
    public DateTime? UsrDtAlteracao { get; set; }

    [Column("USR_UsuarioIncluiu")]
    public short? UsrUsuarioIncluiu { get; set; }

    [Column("USR_UsuarioAlterou")]
    public short? UsrUsuarioAlterou { get; set; }

    [Column("USR_NivelAcesso")]
    [StringLength(1)]
    [Unicode(false)]
    public string? UsrNivelAcesso { get; set; }

    [Column("USR_DataExclusao", TypeName = "smalldatetime")]
    public DateTime? UsrDataExclusao { get; set; }

    [InverseProperty("UsrCodigoNavigation")]
    public virtual ICollection<Cheque> Cheques { get; set; } = new List<Cheque>();

    [InverseProperty("UsuCodigoNavigation")]
    public virtual ICollection<CopsMovimento> CopsMovimentos { get; set; } = new List<CopsMovimento>();

    [InverseProperty("UsuCodigoMovimentoNavigation")]
    public virtual ICollection<Devolucao> Devolucaos { get; set; } = new List<Devolucao>();

    [InverseProperty("UsuCodigoNavigation")]
    public virtual ICollection<Entradum> Entrada { get; set; } = new List<Entradum>();

    [InverseProperty("IvdSerTecnicoNavigation")]
    public virtual ICollection<ItensVendum> ItensVenda { get; set; } = new List<ItensVendum>();

    [InverseProperty("UsrCodigoNavigation")]
    public virtual ICollection<NfceInutilizacao> NfceInutilizacaos { get; set; } = new List<NfceInutilizacao>();

    [InverseProperty("UsrCodigoNavigation")]
    public virtual ICollection<NfeInutilizacao> NfeInutilizacaos { get; set; } = new List<NfeInutilizacao>();

    [ForeignKey("PesCodigo")]
    [InverseProperty("Usuarios")]
    public virtual Pessoa PesCodigoNavigation { get; set; } = null!;

    [InverseProperty("UsrCodigoNavigation")]
    public virtual ICollection<SerCompra> SerCompras { get; set; } = new List<SerCompra>();

    [InverseProperty("UsrCodigoNavigation")]
    public virtual ICollection<SerServicoParteTecnico> SerServicoParteTecnicos { get; set; } = new List<SerServicoParteTecnico>();

    [InverseProperty("UsrCodigoNavigation")]
    public virtual ICollection<SerServico> SerServicos { get; set; } = new List<SerServico>();

    [InverseProperty("UsrUsuarioSistemaNavigation")]
    public virtual ICollection<Vendum> Venda { get; set; } = new List<Vendum>();
}
