using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("NFe_TRANSPORTE")]
public partial class NfeTransporte
{
    [Key]
    [Column("NFe_Numero")]
    [StringLength(9)]
    [Unicode(false)]
    public string NfeNumero { get; set; } = null!;

    [Column("NTRA_Codigo")]
    public int NtraCodigo { get; set; }

    [Column("NTRA_ModalidadeFrete")]
    [StringLength(2)]
    [Unicode(false)]
    public string? NtraModalidadeFrete { get; set; }

    [Column("NTRA_PlacaVeiculo")]
    [StringLength(10)]
    [Unicode(false)]
    public string? NtraPlacaVeiculo { get; set; }

    [Column("NTRA_UF_Placa")]
    [StringLength(2)]
    [Unicode(false)]
    public string? NtraUfPlaca { get; set; }

    [Column("NTRA_CodigoANTT")]
    [StringLength(20)]
    [Unicode(false)]
    public string? NtraCodigoAntt { get; set; }

    [Column("NTRA_Quantidade")]
    [StringLength(10)]
    [Unicode(false)]
    public string? NtraQuantidade { get; set; }

    [Column("NTRA_Marca")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NtraMarca { get; set; }

    [Column("NTRA_Numero")]
    [StringLength(20)]
    [Unicode(false)]
    public string? NtraNumero { get; set; }

    [Column("NTRA_PesoBruto", TypeName = "decimal(10, 3)")]
    public decimal? NtraPesoBruto { get; set; }

    [Column("NTRA_PesoLiquido", TypeName = "decimal(10, 3)")]
    public decimal? NtraPesoLiquido { get; set; }
}
