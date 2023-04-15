using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class rptVoucherAttachment
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string article { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal unitAmt { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [StringLength(100)]
    public string? VoucherValueRemark { get; set; }

    [Column(TypeName = "money")]
    public decimal discount { get; set; }

    [Column(TypeName = "money")]
    public decimal additionalCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal subTotal { get; set; }

    public string? consignee { get; set; }

    [Column(TypeName = "money")]
    public decimal totalAmount { get; set; }

    public string? name { get; set; }

    public string? uom { get; set; }

    [StringLength(100)]
    public string? cCategory { get; set; }

    [StringLength(100)]
    public string? pCategory { get; set; }

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? To { get; set; }

    public bool IsVoid { get; set; }

    public bool IsIssued { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(100)]
    public string? voucherType { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(50)]
    public string? destination { get; set; }

    [StringLength(50)]
    public string? source { get; set; }

    [StringLength(26)]
    public string? SpecificationType { get; set; }

    [StringLength(50)]
    public string? value { get; set; }

    [StringLength(50)]
    public string? attribute { get; set; }

    public int? index { get; set; }

    [StringLength(26)]
    public string? LineItem { get; set; }

    [StringLength(26)]
    public string? LineItemUOM { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? prodDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? expiryDate { get; set; }

    [StringLength(26)]
    public string? SerialCode { get; set; }

    public string? description { get; set; }

    public string? number { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BatchProdDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BatchExpiryDate { get; set; }

    public bool? IsLineItem { get; set; }

    [StringLength(100)]
    public string? cart { get; set; }

    [StringLength(2048)]
    public string? vouchernote { get; set; }

    public string? BankName { get; set; }

    [StringLength(26)]
    public string? PaymentProcessor { get; set; }

    [StringLength(50)]
    public string? Branch { get; set; }

    [StringLength(50)]
    public string? NonCashPaymentNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? maturityDate { get; set; }

    public string? NonCashPaymentDescription { get; set; }

    [StringLength(26)]
    public string? OtherConsignee { get; set; }

    [StringLength(50)]
    public string? RequiredGSLDescription { get; set; }

    [StringLength(26)]
    public string? LineItemWeightCode { get; set; }

    public double? articleWt { get; set; }

    public double? startWt { get; set; }

    public double? endWt { get; set; }

    public double? netWt { get; set; }

    public double? variation { get; set; }

    public bool? overrideArticleDescription { get; set; }

    public string? note { get; set; }

    [StringLength(26)]
    public string? LineItemCoversionCode { get; set; }

    [StringLength(26)]
    public string? LineItemConversionUOM { get; set; }

    public string? LineItemConversionUOMDescription { get; set; }

    public double? LineItemCoversionQuantity { get; set; }

    public double? LineItemCoversionUnitAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? length { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? width { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? height { get; set; }

    [StringLength(50)]
    public string? PhyDimDiscription { get; set; }

    [StringLength(26)]
    public string? accCode { get; set; }

    [StringLength(50)]
    public string? accDesc { get; set; }

    [Column(TypeName = "money")]
    public decimal? debit { get; set; }

    [Column(TypeName = "money")]
    public decimal? credit { get; set; }

    [StringLength(26)]
    public string? cover { get; set; }

    [StringLength(26)]
    public string? table { get; set; }

    [StringLength(26)]
    public string? waiter { get; set; }

    [StringLength(26)]
    public string? mrsNo { get; set; }

    [StringLength(26)]
    public string? fsNo { get; set; }

    [StringLength(26)]
    public string? component { get; set; }
}
