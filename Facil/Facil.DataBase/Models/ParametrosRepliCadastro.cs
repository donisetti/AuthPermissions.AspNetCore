using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("PARAMETROS_REPLI_CADASTRO")]
public partial class ParametrosRepliCadastro
{
    [Key]
    [Column("REP_Codigo")]
    public short RepCodigo { get; set; }

    [Column("REP_Caminho_Servidor")]
    [StringLength(100)]
    [Unicode(false)]
    public string RepCaminhoServidor { get; set; } = null!;

    [Column("REP_NomeBanco")]
    [StringLength(50)]
    [Unicode(false)]
    public string RepNomeBanco { get; set; } = null!;
}
