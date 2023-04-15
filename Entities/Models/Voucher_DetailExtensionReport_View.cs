using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class Voucher_DetailExtensionReport_View
{
    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    [StringLength(26)]
    public string transType { get; set; } = null!;

    public string? transTypeDesc { get; set; }

    public int voucherDefinition { get; set; }

    [StringLength(100)]
    public string? voucherDefnName { get; set; }

    [StringLength(26)]
    public string? consigneeCode { get; set; }

    public string? consigneeName { get; set; }

    [StringLength(20)]
    public string? TIN { get; set; }

    [StringLength(26)]
    public string? consigneeChildCode { get; set; }

    [StringLength(100)]
    public string? consigneeChildDesc { get; set; }

    [StringLength(26)]
    public string? consigneeParentCode { get; set; }

    [StringLength(100)]
    public string? consigneeParentDesc { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(26)]
    public string? sourceStoreCode { get; set; }

    [StringLength(26)]
    public string? destinationStoreCode { get; set; }

    [StringLength(26)]
    public string articleCode { get; set; } = null!;

    public string? articleName { get; set; }

    [StringLength(26)]
    public string? articleChildCode { get; set; }

    [StringLength(100)]
    public string? articleChildDesc { get; set; }

    [StringLength(26)]
    public string? articleParentCode { get; set; }

    [StringLength(100)]
    public string? articleParentDesc { get; set; }

    [StringLength(26)]
    public string? deviceCode { get; set; }

    [StringLength(26)]
    public string? userCode { get; set; }

    [StringLength(26)]
    public string? actOrgUnitCode { get; set; }

    [StringLength(26)]
    public string? orgUnitCode { get; set; }

    [StringLength(50)]
    public string? orgUnitDesc { get; set; }

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? lineItemServChargeAmt { get; set; }

    [Column(TypeName = "money")]
    public decimal? lineItemDiscountAmt { get; set; }

    [Column(TypeName = "money")]
    public decimal taxableAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? taxAmount { get; set; }

    [StringLength(26)]
    public string? UOM { get; set; }

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

    [StringLength(100)]
    public string? brand { get; set; }

    [StringLength(100)]
    public string? generic { get; set; }

    [StringLength(100)]
    public string? model { get; set; }

    [StringLength(25)]
    public string? size { get; set; }

    [StringLength(50)]
    public string? color { get; set; }

    [StringLength(100)]
    public string? manufacturer { get; set; }

    [StringLength(26)]
    public string? country { get; set; }
}
