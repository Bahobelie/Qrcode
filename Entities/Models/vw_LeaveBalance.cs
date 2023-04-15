using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_LeaveBalance
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    [Column(TypeName = "decimal(38, 4)")]
    public decimal? qtyDue { get; set; }

    [Column(TypeName = "decimal(38, 4)")]
    public decimal? qtyConsumed { get; set; }

    public string? name { get; set; }

    [StringLength(50)]
    public string? uom { get; set; }

    public int referingVouDfn { get; set; }

    public int unReferenced { get; set; }

    public bool? referringVoid { get; set; }

    public bool? IsIssued { get; set; }
}
