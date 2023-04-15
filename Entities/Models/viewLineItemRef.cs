using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class viewLineItemRef
{
    [StringLength(26)]
    public string LineItemCode { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal taxableAmount { get; set; }

    public int? tax { get; set; }

    [Column(TypeName = "money")]
    public decimal? taxAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? calculatedCost { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(26)]
    public string LRCode { get; set; } = null!;

    [StringLength(26)]
    public string referenced { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal value { get; set; }

    [StringLength(100)]
    public string? LRremark { get; set; }

    [StringLength(26)]
    public string serialCode { get; set; } = null!;

    [StringLength(26)]
    public string serialDefinition { get; set; } = null!;

    [StringLength(20)]
    public string number { get; set; } = null!;

    [StringLength(100)]
    public string? serialRemark { get; set; }
}
