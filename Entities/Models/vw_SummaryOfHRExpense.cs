using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_SummaryOfHRExpense
{
    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string periodName { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string article { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [StringLength(26)]
    public string? UOM { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    public string name { get; set; } = null!;

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? consignee { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [Column(TypeName = "money")]
    public decimal taxableAmount { get; set; }
}
