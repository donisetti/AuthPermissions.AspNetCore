using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("TIPO_NOTAFISCAL")]
public partial class TipoNotafiscal
{
    [Key]
    [Column("TNF_Codigo")]
    public short TnfCodigo { get; set; }

    [Column("TNF_Descricao")]
    [StringLength(100)]
    [Unicode(false)]
    public string TnfDescricao { get; set; } = null!;

    [InverseProperty("TnfCodigoNavigation")]
    public virtual ICollection<EntradaInsumo> EntradaInsumos { get; set; } = new List<EntradaInsumo>();

    [InverseProperty("TnfCodigoNavigation")]
    public virtual ICollection<EntradaProduto> EntradaProdutos { get; set; } = new List<EntradaProduto>();

    [InverseProperty("TnfCodigoNavigation")]
    public virtual ICollection<TransferenciaInsumo> TransferenciaInsumos { get; set; } = new List<TransferenciaInsumo>();

    [InverseProperty("TnfCodigoNavigation")]
    public virtual ICollection<TransferenciaProduto> TransferenciaProdutos { get; set; } = new List<TransferenciaProduto>();
}
