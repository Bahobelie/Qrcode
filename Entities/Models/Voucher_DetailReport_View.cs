using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class Voucher_DetailReport_View
{
    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? consigneeCode { get; set; }

    public string? consigneeName { get; set; }

    [StringLength(20)]
    public string? TIN { get; set; }

    public string? Telephone { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(26)]
    public string? articleCode { get; set; }

    public string? articleName { get; set; }

    [StringLength(26)]
    public string? articleChildCode { get; set; }

    [StringLength(100)]
    public string? articleChildDesc { get; set; }

    [StringLength(26)]
    public string? articleParentCode { get; set; }

    [StringLength(100)]
    public string? articleParentDesc { get; set; }

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? lineItemServChargeAmt { get; set; }

    [Column(TypeName = "money")]
    public decimal? lineItemDiscountAmt { get; set; }

    [Column(TypeName = "money")]
    public decimal? taxableAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? taxAmount { get; set; }

    [StringLength(26)]
    public string? UOM { get; set; }

    [StringLength(26)]
    public string? consigneeChildCode { get; set; }

    [StringLength(100)]
    public string? consigneeChildDesc { get; set; }

    [StringLength(26)]
    public string? consigneeParentCode { get; set; }

    [StringLength(100)]
    public string? consigneeParentDesc { get; set; }

    [Column(TypeName = "money")]
    public decimal? subTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? additionalCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal? discount { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalTaxableAmt { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalTaxAmt { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }
}
