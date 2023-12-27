using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("SER_SERVICO_PARTE_TECNICO")]
public partial class SerServicoParteTecnico
{
    [Key]
    [Column("SERPARTEC_Codigo")]
    public int SerpartecCodigo { get; set; }

    [Column("USR_Codigo")]
    public short? UsrCodigo { get; set; }

    [Column("SERPAR_Codigo")]
    public int? SerparCodigo { get; set; }

    [ForeignKey("SerparCodigo")]
    [InverseProperty("SerServicoParteTecnicos")]
    public virtual SerServicoParte? SerparCodigoNavigation { get; set; }

    [ForeignKey("UsrCodigo")]
    [InverseProperty("SerServicoParteTecnicos")]
    public virtual Usuario? UsrCodigoNavigation { get; set; }
}
