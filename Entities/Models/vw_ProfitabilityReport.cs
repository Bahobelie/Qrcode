using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ProfitabilityReport
{
    [StringLength(26)]
    public string article { get; set; } = null!;

    public string name { get; set; } = null!;

    [Column(TypeName = "decimal(38, 4)")]
    public decimal? quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? average { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? TotalPrice { get; set; }
}
