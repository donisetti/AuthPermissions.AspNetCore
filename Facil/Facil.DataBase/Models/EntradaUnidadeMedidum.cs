using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("ENTRADA_UNIDADE_MEDIDA")]
public partial class EntradaUnidadeMedidum
{
    [Key]
    [Column("EUN_Codigo")]
    public short EunCodigo { get; set; }

    [Column("EUN_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string EunDescricao { get; set; } = null!;

    [Column("UNI_Codigo")]
    public short? UniCodigo { get; set; }

    [Column("EUN_FatorSaida", TypeName = "decimal(15, 2)")]
    public decimal? EunFatorSaida { get; set; }

    [Column("EUN_FatorEntrada", TypeName = "decimal(15, 2)")]
    public decimal? EunFatorEntrada { get; set; }

    [ForeignKey("UniCodigo")]
    [InverseProperty("EntradaUnidadeMedida")]
    public virtual UnidadeMedidum? UniCodigoNavigation { get; set; }
}
