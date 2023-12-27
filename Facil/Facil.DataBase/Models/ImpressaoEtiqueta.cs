using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Keyless]
[Table("IMPRESSAO_ETIQUETAS")]
public partial class ImpressaoEtiqueta
{
    [Column("PRO_Codigo")]
    public int ProCodigo { get; set; }

    [Column("ETQ_Quantidade")]
    public int EtqQuantidade { get; set; }

    [Column("ETQ_DataImpressão", TypeName = "smalldatetime")]
    public DateTime EtqDataImpressão { get; set; }

    [Column("ETQ_Codigo")]
    public int EtqCodigo { get; set; }

    [Column("EMP_Codigo")]
    public short? EmpCodigo { get; set; }
}
