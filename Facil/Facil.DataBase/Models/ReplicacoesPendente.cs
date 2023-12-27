using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("REPLICACOES_PENDENTES")]
public partial class ReplicacoesPendente
{
    [Key]
    [Column("PEN_Codigo")]
    public short PenCodigo { get; set; }

    [Column("PEN_Caminho_Servidor")]
    [StringLength(100)]
    [Unicode(false)]
    public string PenCaminhoServidor { get; set; } = null!;

    [Column("PEN_NomeBanco")]
    [StringLength(50)]
    [Unicode(false)]
    public string PenNomeBanco { get; set; } = null!;

    [Column("PEN_SqlInstrucao")]
    [Unicode(false)]
    public string PenSqlInstrucao { get; set; } = null!;

    [Column("PEN_Observacao")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PenObservacao { get; set; }
}
