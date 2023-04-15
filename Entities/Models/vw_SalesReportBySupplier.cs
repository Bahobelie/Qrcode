using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_SalesReportBySupplier
{
    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    public int voucherDef { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime voucherIssuedDate { get; set; }

    [StringLength(26)]
    public string? voucherConsignee { get; set; }

    public string? supplier { get; set; }

    [StringLength(26)]
    public string ItemCode { get; set; } = null!;

    public string ItemDescription { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal priceValue { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [StringLength(26)]
    public string? source { get; set; }

    [StringLength(26)]
    public string? destination { get; set; }
}
