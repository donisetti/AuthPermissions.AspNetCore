using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("SER_TIPO_SERVICO")]
public partial class SerTipoServico
{
    [Key]
    [Column("TSE_Codigo")]
    public short TseCodigo { get; set; }

    [Column("TSE_Descricao")]
    [StringLength(15)]
    [Unicode(false)]
    public string? TseDescricao { get; set; }

    [InverseProperty("TseCodigoNavigation")]
    public virtual ICollection<SerServico> SerServicos { get; set; } = new List<SerServico>();
}
