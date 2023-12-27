using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("NFe_REGRAS_ICMS_ORIGEM")]
public partial class NfeRegrasIcmsOrigem
{
    [Key]
    [Column("RICMS_CodigoNCM")]
    [StringLength(8)]
    [Unicode(false)]
    public string RicmsCodigoNcm { get; set; } = null!;

    [Column("RICMS_UF_Origem")]
    [StringLength(2)]
    [Unicode(false)]
    public string RicmsUfOrigem { get; set; } = null!;

    [Column("RICMS_DescricaoRegra")]
    [StringLength(300)]
    [Unicode(false)]
    public string RicmsDescricaoRegra { get; set; } = null!;

    [Column("RICMS_MensagemAdicional")]
    [StringLength(300)]
    [Unicode(false)]
    public string RicmsMensagemAdicional { get; set; } = null!;
}
