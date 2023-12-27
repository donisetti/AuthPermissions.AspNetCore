using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Keyless]
[Table("ROTINAS_AUTO")]
public partial class RotinasAuto
{
    [Column("ROT_DataUltimoEnvioEmail", TypeName = "smalldatetime")]
    public DateTime RotDataUltimoEnvioEmail { get; set; }

    [Column("ROT_DataTentativaEnvioEmail", TypeName = "smalldatetime")]
    public DateTime RotDataTentativaEnvioEmail { get; set; }

    [Column("EMP_Codigo")]
    public short EmpCodigo { get; set; }

    [Column("ROT_RotinaEmailAuto")]
    public bool? RotRotinaEmailAuto { get; set; }

    [Column("ROT_Maquina_NFeDest")]
    [StringLength(100)]
    [Unicode(false)]
    public string? RotMaquinaNfeDest { get; set; }

    [Column("ROT_BaixarNfeDest")]
    public bool? RotBaixarNfeDest { get; set; }
}
