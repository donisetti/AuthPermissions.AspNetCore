using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("NFe_IBGE_CIDADE")]
public partial class NfeIbgeCidade
{
    [Key]
    [Column("CID_Codigo")]
    public int CidCodigo { get; set; }

    [Column("CID_NomeCidade")]
    [StringLength(50)]
    [Unicode(false)]
    public string CidNomeCidade { get; set; } = null!;

    [Column("CID_SiglaEstado")]
    [StringLength(2)]
    [Unicode(false)]
    public string CidSiglaEstado { get; set; } = null!;
}
