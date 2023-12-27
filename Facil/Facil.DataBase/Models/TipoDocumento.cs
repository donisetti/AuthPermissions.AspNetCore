using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("TIPO_DOCUMENTOS")]
public partial class TipoDocumento
{
    [Key]
    [Column("TDO_Codigo")]
    public short TdoCodigo { get; set; }

    [Column("TDO_Descricao")]
    [StringLength(50)]
    [Unicode(false)]
    public string TdoDescricao { get; set; } = null!;

    [InverseProperty("TdoCodigoNavigation")]
    public virtual ICollection<DocumentoCliente> DocumentoClientes { get; set; } = new List<DocumentoCliente>();

    [InverseProperty("TdoCodigoNavigation")]
    public virtual ICollection<SaidaInsumo> SaidaInsumos { get; set; } = new List<SaidaInsumo>();

    [InverseProperty("TdoCodigoNavigation")]
    public virtual ICollection<SaidaProduto> SaidaProdutos { get; set; } = new List<SaidaProduto>();
}
