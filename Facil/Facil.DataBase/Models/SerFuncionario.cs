using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("SER_FUNCIONARIO")]
public partial class SerFuncionario
{
    [Key]
    [Column("FUN_Codigo")]
    public short FunCodigo { get; set; }

    [Column("FUN_Nome")]
    [StringLength(30)]
    [Unicode(false)]
    public string? FunNome { get; set; }

    [Column("FUN_DataCadastro", TypeName = "datetime")]
    public DateTime? FunDataCadastro { get; set; }
}
