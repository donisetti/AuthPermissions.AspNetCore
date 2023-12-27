using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("SER_VEICULO")]
public partial class SerVeiculo
{
    [Key]
    [Column("VEI_Codigo")]
    public int VeiCodigo { get; set; }

    [Column("VEI_DataCadastro", TypeName = "datetime")]
    public DateTime? VeiDataCadastro { get; set; }

    [Column("VEI_DataExclusao", TypeName = "smalldatetime")]
    public DateTime? VeiDataExclusao { get; set; }

    [Column("VEI_Ano")]
    [StringLength(4)]
    [Unicode(false)]
    public string? VeiAno { get; set; }

    [Column("VEI_Placa")]
    [StringLength(7)]
    [Unicode(false)]
    public string? VeiPlaca { get; set; }

    [Column("PES_Codigo")]
    public int PesCodigo { get; set; }

    [Column("CAR_Codigo")]
    public short CarCodigo { get; set; }

    [Column("COR_Codigo")]
    public short CorCodigo { get; set; }

    [Column("VEI_Frota")]
    [StringLength(10)]
    [Unicode(false)]
    public string? VeiFrota { get; set; }

    [Column("VEI_Serie")]
    [StringLength(30)]
    [Unicode(false)]
    public string? VeiSerie { get; set; }

    [ForeignKey("CarCodigo")]
    [InverseProperty("SerVeiculos")]
    public virtual SerCarro CarCodigoNavigation { get; set; } = null!;

    [ForeignKey("CorCodigo")]
    [InverseProperty("SerVeiculos")]
    public virtual SerCor CorCodigoNavigation { get; set; } = null!;

    [InverseProperty("VeiCodigoNavigation")]
    public virtual ICollection<SerServico> SerServicos { get; set; } = new List<SerServico>();
}
