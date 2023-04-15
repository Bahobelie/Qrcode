using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_MinStockLevel
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(26)]
    public string store { get; set; } = null!;

    [StringLength(26)]
    public string? period { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? minLevel { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? economicOrderQty { get; set; }
}
