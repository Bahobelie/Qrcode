using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class FixedAssetInventoryView
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string otherConsignee { get; set; } = null!;

    [StringLength(26)]
    public string requiredGSL { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    [StringLength(26)]
    public string articleCode { get; set; } = null!;

    public string articleName { get; set; } = null!;

    [StringLength(15)]
    public string uom { get; set; } = null!;

    [StringLength(100)]
    public string? brand { get; set; }

    [StringLength(100)]
    public string? model { get; set; }

    [StringLength(50)]
    public string? color { get; set; }

    [StringLength(26)]
    public string? country { get; set; }
}
