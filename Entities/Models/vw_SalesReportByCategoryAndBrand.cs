using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_SalesReportByCategoryAndBrand
{
    [StringLength(100)]
    public string category { get; set; } = null!;

    [StringLength(100)]
    public string? brand { get; set; }

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "money")]
    public decimal? saleValue { get; set; }

    [Column(TypeName = "decimal(38, 4)")]
    public decimal? quantity { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }
}
