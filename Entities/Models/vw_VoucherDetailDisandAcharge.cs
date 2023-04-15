using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherDetailDisandAcharge
{
    [StringLength(26)]
    public string code { get; set; } = null!;

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

    [StringLength(26)]
    public string valueFactorReference { get; set; } = null!;

    public bool isDiscount { get; set; }

    [Column(TypeName = "money")]
    public decimal amount { get; set; }

    [StringLength(50)]
    public string description { get; set; } = null!;

    public bool isPercent { get; set; }

    public double value { get; set; }

    public int? typeList { get; set; }
}
