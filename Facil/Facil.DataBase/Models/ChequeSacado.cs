using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("CHEQUE_SACADO")]
public partial class ChequeSacado
{
    [Key]
    [Column("SAC_Codigo")]
    public int SacCodigo { get; set; }

    [Column("SAC_Nome")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SacNome { get; set; }

    [Column("SAC_CPF_CNPJ")]
    [StringLength(15)]
    [Unicode(false)]
    public string? SacCpfCnpj { get; set; }

    [Column("SAC_ContaCorrente")]
    [StringLength(15)]
    [Unicode(false)]
    public string? SacContaCorrente { get; set; }

    [Column("SAC_Agencia")]
    [StringLength(15)]
    [Unicode(false)]
    public string? SacAgencia { get; set; }

    [Column("BAN_Codigo")]
    public short? BanCodigo { get; set; }

    [ForeignKey("BanCodigo")]
    [InverseProperty("ChequeSacados")]
    public virtual ChequeBanco? BanCodigoNavigation { get; set; }

    [InverseProperty("SacCodigoNavigation")]
    public virtual ICollection<ChequeTelefoneSacado> ChequeTelefoneSacados { get; set; } = new List<ChequeTelefoneSacado>();

    [InverseProperty("SacCodigoNavigation")]
    public virtual ICollection<Cheque> Cheques { get; set; } = new List<Cheque>();
}
