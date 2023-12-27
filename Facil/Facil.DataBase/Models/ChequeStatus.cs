using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("CHEQUE_STATUS")]
public partial class ChequeStatus
{
    [Key]
    [Column("STS_Codigo")]
    public short StsCodigo { get; set; }

    [Column("STS_Descricao")]
    [StringLength(30)]
    [Unicode(false)]
    public string? StsDescricao { get; set; }

    [Column("STS_Sigla")]
    [StringLength(3)]
    [Unicode(false)]
    public string? StsSigla { get; set; }

    [InverseProperty("StsCodigoNavigation")]
    public virtual ICollection<Cheque> Cheques { get; set; } = new List<Cheque>();
}
