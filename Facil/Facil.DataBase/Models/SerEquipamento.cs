using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("SER_EQUIPAMENTO")]
public partial class SerEquipamento
{
    [Key]
    [Column("EQUI_Codigo")]
    public int EquiCodigo { get; set; }

    [Column("EQUI_DataCadastro", TypeName = "smalldatetime")]
    public DateTime? EquiDataCadastro { get; set; }

    [Column("EQUI_Serial")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EquiSerial { get; set; }

    [Column("PES_Codigo")]
    public int? PesCodigo { get; set; }

    [Column("EQUI_DataExclusao", TypeName = "smalldatetime")]
    public DateTime? EquiDataExclusao { get; set; }

    [Column("EQUINOM_Codigo")]
    public int? EquinomCodigo { get; set; }

    [Column("COR_Codigo")]
    public short? CorCodigo { get; set; }

    [Column("EQUI_ValorImobilizado", TypeName = "decimal(15, 2)")]
    public decimal? EquiValorImobilizado { get; set; }

    [ForeignKey("CorCodigo")]
    [InverseProperty("SerEquipamentos")]
    public virtual SerCor? CorCodigoNavigation { get; set; }

    [ForeignKey("EquinomCodigo")]
    [InverseProperty("SerEquipamentos")]
    public virtual SerEquipamentoNome? EquinomCodigoNavigation { get; set; }

    [ForeignKey("PesCodigo")]
    [InverseProperty("SerEquipamentos")]
    public virtual Pessoa? PesCodigoNavigation { get; set; }

    [InverseProperty("EquiCodigoNavigation")]
    public virtual ICollection<SerEquipamentoServico> SerEquipamentoServicos { get; set; } = new List<SerEquipamentoServico>();

    [InverseProperty("EquiCodigoNavigation")]
    public virtual ICollection<SerServico> SerServicos { get; set; } = new List<SerServico>();
}
