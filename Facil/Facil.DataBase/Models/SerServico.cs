using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("SER_SERVICO")]
public partial class SerServico
{
    [Key]
    [Column("SER_Codigo")]
    public int SerCodigo { get; set; }

    [Column("SER_DataMovimento", TypeName = "datetime")]
    public DateTime? SerDataMovimento { get; set; }

    [Column("SER_DataFechamento", TypeName = "datetime")]
    public DateTime? SerDataFechamento { get; set; }

    [Column("VEI_Codigo")]
    public int? VeiCodigo { get; set; }

    [Column("PES_Codigo")]
    public int PesCodigo { get; set; }

    [Column("USR_Codigo")]
    public short? UsrCodigo { get; set; }

    [Column("EQUI_Codigo")]
    public int? EquiCodigo { get; set; }

    [Column("SER_NumeroControle")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SerNumeroControle { get; set; }

    [Column("STA_Codigo")]
    public short? StaCodigo { get; set; }

    [Column("SER_DefeitoReclamado")]
    [StringLength(300)]
    [Unicode(false)]
    public string? SerDefeitoReclamado { get; set; }

    [Column("SER_Solicitante")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SerSolicitante { get; set; }

    [Column("SER_DataFaturado", TypeName = "smalldatetime")]
    public DateTime? SerDataFaturado { get; set; }

    [Column("SER_DataInativo", TypeName = "smalldatetime")]
    public DateTime? SerDataInativo { get; set; }

    [Column("SER_OSCliente")]
    [StringLength(15)]
    [Unicode(false)]
    public string? SerOscliente { get; set; }

    [Column("SER_SolucaoDefeito")]
    [StringLength(300)]
    [Unicode(false)]
    public string? SerSolucaoDefeito { get; set; }

    [Column("SER_KmHrs")]
    [StringLength(15)]
    [Unicode(false)]
    public string? SerKmHrs { get; set; }

    [Column("SER_NotaFiscalFatura")]
    [StringLength(10)]
    [Unicode(false)]
    public string? SerNotaFiscalFatura { get; set; }

    [Column("SER_NotaFiscalServico")]
    [StringLength(10)]
    [Unicode(false)]
    public string? SerNotaFiscalServico { get; set; }

    [Column("SER_NumeroPedidoCliente")]
    [StringLength(10)]
    [Unicode(false)]
    public string? SerNumeroPedidoCliente { get; set; }

    [Column("TSE_Codigo")]
    public short? TseCodigo { get; set; }

    [Column("SER_Observacao")]
    [StringLength(300)]
    [Unicode(false)]
    public string? SerObservacao { get; set; }

    [Column("SER_DataEntrega", TypeName = "smalldatetime")]
    public DateTime? SerDataEntrega { get; set; }

    [Column("SER_DataDevolucao", TypeName = "smalldatetime")]
    public DateTime? SerDataDevolucao { get; set; }

    [Column("SER_DataEstorno", TypeName = "smalldatetime")]
    public DateTime? SerDataEstorno { get; set; }

    [ForeignKey("EquiCodigo")]
    [InverseProperty("SerServicos")]
    public virtual SerEquipamento? EquiCodigoNavigation { get; set; }

    [ForeignKey("PesCodigo")]
    [InverseProperty("SerServicos")]
    public virtual Pessoa PesCodigoNavigation { get; set; } = null!;

    [InverseProperty("SerCodigoNavigation")]
    public virtual ICollection<SerEquipamentoServico> SerEquipamentoServicos { get; set; } = new List<SerEquipamentoServico>();

    [InverseProperty("SerCodigoNavigation")]
    public virtual ICollection<SerServicoParte> SerServicoPartes { get; set; } = new List<SerServicoParte>();

    [ForeignKey("StaCodigo")]
    [InverseProperty("SerServicos")]
    public virtual SerStatus? StaCodigoNavigation { get; set; }

    [ForeignKey("TseCodigo")]
    [InverseProperty("SerServicos")]
    public virtual SerTipoServico? TseCodigoNavigation { get; set; }

    [ForeignKey("UsrCodigo")]
    [InverseProperty("SerServicos")]
    public virtual Usuario? UsrCodigoNavigation { get; set; }

    [ForeignKey("VeiCodigo")]
    [InverseProperty("SerServicos")]
    public virtual SerVeiculo? VeiCodigoNavigation { get; set; }

    [InverseProperty("SerCodigoNavigation")]
    public virtual ICollection<Vendum> Venda { get; set; } = new List<Vendum>();
}
