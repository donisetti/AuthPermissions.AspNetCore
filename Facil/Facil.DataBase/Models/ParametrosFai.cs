using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PARAMETROS_FAI")]
public partial class ParametrosFai
{
    [Key]
    [Column("PARF_Codigo")]
    public short ParfCodigo { get; set; }

    [Column("EMP_Codigo")]
    public short? EmpCodigo { get; set; }

    [Column("PARF_AtualizaClassificacao")]
    public bool? ParfAtualizaClassificacao { get; set; }
}
