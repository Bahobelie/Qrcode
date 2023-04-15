using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class Voucher_HeaderReport_view
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

    public string periodName { get; set; } = null!;

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(50)]
    public string? objectStateDesc { get; set; }

    [StringLength(26)]
    public string? deviceCode { get; set; }

    public string? deviceName { get; set; }

    [StringLength(26)]
    public string? userCode { get; set; }

    [StringLength(30)]
    public string? userName { get; set; }

    [StringLength(26)]
    public string? actOrgUnitCode { get; set; }

    [StringLength(26)]
    public string paymentMethod { get; set; } = null!;

    public string paymentMethodDesc { get; set; } = null!;

    [StringLength(26)]
    public string? orgUnitCode { get; set; }

    [StringLength(50)]
    public string? orgUnitDesc { get; set; }

    [StringLength(26)]
    public string? sourceStoreCode { get; set; }

    [StringLength(26)]
    public string? destinationStoreCode { get; set; }

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
