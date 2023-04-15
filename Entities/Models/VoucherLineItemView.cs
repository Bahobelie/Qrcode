using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class VoucherLineItemView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string lineItemCode { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    [StringLength(26)]
    public string article { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [StringLength(26)]
    public string? UOM { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? calculatedCost { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    public string name { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }
}
