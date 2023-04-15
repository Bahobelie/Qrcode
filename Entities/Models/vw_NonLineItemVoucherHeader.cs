using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_NonLineItemVoucherHeader
{
    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(100)]
    public string? voucherDefinitionName { get; set; }

    [StringLength(26)]
    public string? consigneeCode { get; set; }

    public string? consigneeName { get; set; }

    [StringLength(20)]
    public string? consigneeTIN { get; set; }

    public string? consigneeTelephone { get; set; }

    [StringLength(26)]
    public string? childPreferenceCode { get; set; }

    [StringLength(100)]
    public string? childPreferenceDesc { get; set; }

    [StringLength(26)]
    public string? parentPreferenceCode { get; set; }

    [StringLength(100)]
    public string? parentPreferenceDesc { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(26)]
    public string? periodCode { get; set; }

    public string? periodName { get; set; }

    [StringLength(26)]
    public string? periodTypeCode { get; set; }

    public string? periodTypeDescription { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? periodStartDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? periodEndDateTime { get; set; }

    [StringLength(26)]
    public string? deviceCode { get; set; }

    public string? deviceName { get; set; }

    [StringLength(26)]
    public string? userCode { get; set; }

    [StringLength(30)]
    public string? userName { get; set; }

    [StringLength(26)]
    public string? orgUnitDefCode { get; set; }

    [StringLength(50)]
    public string? orgUnitDefDescription { get; set; }

    [Column(TypeName = "money")]
    public decimal? subTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? additionalCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal? discount { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string? lastObjectStateCode { get; set; }

    [StringLength(50)]
    public string? lastObjectStateDescription { get; set; }

    [StringLength(26)]
    public string? color { get; set; }

    public string? voucherNote { get; set; }

    [StringLength(26)]
    public string transactionType { get; set; } = null!;

    public string? transactionTypeDescription { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(26)]
    public string? firstVouchExtCode { get; set; }

    [StringLength(50)]
    public string? firstVouchExtDescription { get; set; }

    [StringLength(26)]
    public string? firstVouchExtValue { get; set; }

    [StringLength(26)]
    public string? secondVouchExtCode { get; set; }

    [StringLength(50)]
    public string? secondVouchExtDescription { get; set; }

    [StringLength(26)]
    public string? secondVouchExtValue { get; set; }

    [StringLength(26)]
    public string? thirdVouchExtCode { get; set; }

    [StringLength(50)]
    public string? thirdVouchExtDescription { get; set; }

    [StringLength(26)]
    public string? thirdVouchExtValue { get; set; }

    [StringLength(26)]
    public string? fourthVouchExtCode { get; set; }

    [StringLength(50)]
    public string? fourthVouchExtDescription { get; set; }

    [StringLength(26)]
    public string? fourthVouchExtValue { get; set; }

    [Column(TypeName = "money")]
    public decimal? VATtaxableAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? VATtaxAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? TOT1taxableAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? TOT1taxAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? TOT2taxableAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? TOT2taxAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? NonTaxableAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? WithholdingTaxableAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? IncomeTaxtaxableAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? IncomeTaxAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? EmployeePensionTaxableAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? EmployeePensionTaxAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? CompanyPensionTaxableAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? CompanyPensionTaxAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? WithholdingTaxAmount { get; set; }

    public string? backwardReferences { get; set; }

    public string? forwardReferences { get; set; }

    public string? InternalReference { get; set; }

    [StringLength(26)]
    public string? firstOtherConsReqGSLCode { get; set; }

    [StringLength(26)]
    public string? firstOtherConsigneeCode { get; set; }

    public string? firstOtherConsigneeName { get; set; }

    [StringLength(26)]
    public string? secondOtherConsReqGSLCode { get; set; }

    [StringLength(26)]
    public string? secondOtherConsigneeCode { get; set; }

    public string? secondOtherConsigneeName { get; set; }

    [StringLength(26)]
    public string? thirdOtherConsReqGSLCode { get; set; }

    [StringLength(26)]
    public string? thirdOtherConsigneeCode { get; set; }

    public string? thirdOtherConsigneeName { get; set; }

    [StringLength(26)]
    public string? paymentMethodCode { get; set; }

    public string? paymentMethodDescription { get; set; }

    [StringLength(26)]
    public string? paymentProcesserCode { get; set; }

    [StringLength(50)]
    public string? paymentProcesserDescription { get; set; }

    [StringLength(26)]
    public string? bankCode { get; set; }

    public string? bankName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? nonCashPaymentIssuedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? nonCashPaymentMaturityDate { get; set; }

    [StringLength(50)]
    public string? nonCashPaymentNumber { get; set; }

    [Column(TypeName = "money")]
    public decimal? nonCashPaymentRate { get; set; }

    [Column(TypeName = "money")]
    public decimal? nonCashPaymentAmount { get; set; }

    [StringLength(26)]
    public string? nonCashPaymentCurrencyCode { get; set; }

    [StringLength(50)]
    public string? nonCashPaymentCurrencyDescription { get; set; }

    [StringLength(8)]
    public string? nonCashPaymentCurrencyAbbreviation { get; set; }

    [StringLength(26)]
    public string? voucherOrgUnitCode { get; set; }

    [StringLength(50)]
    public string? voucherOrgUnitDescription { get; set; }

    public string? lastActivityDescription { get; set; }
}
