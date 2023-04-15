using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("DepreciationRule", Schema = "common")]
public partial class DepreciationRule
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string preference { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal straightLine { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal declining { get; set; }

    public string? remark { get; set; }
}
