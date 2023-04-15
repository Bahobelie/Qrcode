using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ProgressTaxRate
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? taxCode { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal min { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal max { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? rate { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? Constant { get; set; }

    [StringLength(50)]
    public string? description { get; set; }
}
