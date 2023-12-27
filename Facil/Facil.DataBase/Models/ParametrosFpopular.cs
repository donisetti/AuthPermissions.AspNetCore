using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Keyless]
[Table("PARAMETROS_FPOPULAR")]
public partial class ParametrosFpopular
{
    [Column("FPO_USUARIO")]
    public int FpoUsuario { get; set; }

    [Column("FPO_SENHA")]
    [StringLength(50)]
    [Unicode(false)]
    public string FpoSenha { get; set; } = null!;

    [Column("FPO_CODIGO_SOLICITACAO")]
    [StringLength(30)]
    [Unicode(false)]
    public string FpoCodigoSolicitacao { get; set; } = null!;

    [Column("FPO_CODIGO_AUTORIZACAOFP")]
    [StringLength(30)]
    [Unicode(false)]
    public string FpoCodigoAutorizacaofp { get; set; } = null!;

    [Column("FPO_CODIGO_CUPOM")]
    [StringLength(30)]
    [Unicode(false)]
    public string FpoCodigoCupom { get; set; } = null!;

    [Column("FPO_UsuarioVendedor")]
    [StringLength(30)]
    [Unicode(false)]
    public string? FpoUsuarioVendedor { get; set; }

    [Column("FPO_SenhaVendedor")]
    [StringLength(30)]
    [Unicode(false)]
    public string? FpoSenhaVendedor { get; set; }

    [Column("FPO_Codigo")]
    public short? FpoCodigo { get; set; }
}
