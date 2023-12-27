using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

[Table("CLASSIFICACAO_TIPO_MEDICAMENTO")]
public partial class ClassificacaoTipoMedicamento
{
    [Key]
    [Column("CLATMED_Codigo")]
    public short ClatmedCodigo { get; set; }

    [Column("CLATMED_Descricao")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ClatmedDescricao { get; set; }

    [InverseProperty("ClatmedCodigoNavigation")]
    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
