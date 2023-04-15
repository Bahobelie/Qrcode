using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherIntegrityView
{
    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string? periodCode { get; set; }

    [StringLength(26)]
    public string? periodName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? startDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? endDate { get; set; }

    [StringLength(26)]
    public string? periodTypeCode { get; set; }

    [StringLength(50)]
    public string? periodTypeDesc { get; set; }

    public int voucherDefinition { get; set; }

    [StringLength(100)]
    public string? voucherDefinitionName { get; set; }

    [StringLength(26)]
    public string? branchCode { get; set; }

    [StringLength(50)]
    public string? branchName { get; set; }

    [Column(TypeName = "money")]
    public decimal lineItemSubTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal subTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? subtotalDiff { get; set; }

    [Column(TypeName = "money")]
    public decimal lineItemTotalTax { get; set; }

    [Column(TypeName = "money")]
    public decimal totalTax { get; set; }

    [Column(TypeName = "money")]
    public decimal? taxDiff { get; set; }

    [Column(TypeName = "money")]
    public decimal lineItemAdditionalCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal additionalCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal? additionalChargeDiff { get; set; }

    [Column(TypeName = "money")]
    public decimal lineItemDiscount { get; set; }

    [Column(TypeName = "money")]
    public decimal discount { get; set; }

    [Column(TypeName = "money")]
    public decimal? discountDiff { get; set; }

    [Column(TypeName = "money")]
    public decimal? grandSum { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? grandTotalDiff { get; set; }

    [StringLength(26)]
    public string? user { get; set; }

    [StringLength(26)]
    public string? device { get; set; }
}
