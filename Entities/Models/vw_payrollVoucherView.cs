using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_payrollVoucherView
{
    [StringLength(26)]
    public string? taxTransactionCode { get; set; }

    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    public int? taxType { get; set; }

    [Column(TypeName = "money")]
    public decimal? taxAmount { get; set; }

    public int? tax { get; set; }

    [StringLength(50)]
    public string? description { get; set; }

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? consigneeCode { get; set; }

    [StringLength(62)]
    public string? consigneeName { get; set; }

    [StringLength(26)]
    public string article { get; set; } = null!;

    public string articleName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [StringLength(26)]
    public string? lastActivity { get; set; }

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [StringLength(26)]
    public string? UOM { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    [StringLength(26)]
    public string preference { get; set; } = null!;

    [StringLength(26)]
    public string? referenced { get; set; }

    [StringLength(26)]
    public string? lineItemReference { get; set; }

    [StringLength(26)]
    public string lineItemCode { get; set; } = null!;

    [StringLength(26)]
    public string? category { get; set; }

    [Column(TypeName = "money")]
    public decimal? amount { get; set; }

    [StringLength(26)]
    public string categoryCode { get; set; } = null!;

    [StringLength(100)]
    public string categoryDescription { get; set; } = null!;
}
