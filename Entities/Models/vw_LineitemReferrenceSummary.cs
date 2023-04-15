using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_LineitemReferrenceSummary
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? article { get; set; }

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    public string? name { get; set; }

    public string uom { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "decimal(38, 4)")]
    public decimal? qtyConsumed { get; set; }

    [Column(TypeName = "decimal(38, 4)")]
    public decimal? qtyDue { get; set; }

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    public int referingVouDfn { get; set; }

    public int unReferenced { get; set; }

    public int? referringVoid { get; set; }
}
