using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("CNETVariation", Schema = "Production")]
public partial class CNETVariation
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string lineItem { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal minVariation { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal maxVariation { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
