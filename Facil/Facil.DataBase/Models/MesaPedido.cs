using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("MESA_PEDIDO")]
public partial class MesaPedido
{
    [Key]
    [Column("PPZ_Codigo")]
    public short PpzCodigo { get; set; }

    [Column("MSA_Codigo")]
    public short MsaCodigo { get; set; }

    [Column("PPZ_Enviado_Cozinha")]
    public bool PpzEnviadoCozinha { get; set; }

    [Column("PPZ_Pedido_Aberto")]
    public bool PpzPedidoAberto { get; set; }

    [InverseProperty("PpzCodigoNavigation")]
    public virtual ICollection<MesaProdutoPedidoMesa> MesaProdutoPedidoMesas { get; set; } = new List<MesaProdutoPedidoMesa>();

    [ForeignKey("MsaCodigo")]
    [InverseProperty("MesaPedidos")]
    public virtual Mesa MsaCodigoNavigation { get; set; } = null!;
}
