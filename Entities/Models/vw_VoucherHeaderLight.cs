using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherHeaderLight
{
    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(100)]
    public string? voucherDefinitionName { get; set; }

    [StringLength(50)]
    public string? subSystem { get; set; }

    [StringLength(26)]
    public string transactionType { get; set; } = null!;

    public string? transactionTypeDescription { get; set; }

    [StringLength(26)]
    public string? consigneeCode { get; set; }

    public string? consigneeName { get; set; }

    public string? consigneeTelephone { get; set; }

    [StringLength(26)]
    public string? childPreferenceCode { get; set; }

    [StringLength(100)]
    public string? childPreferenceDesc { get; set; }

    [StringLength(26)]
    public string? parentPreferenceCode { get; set; }

    [StringLength(100)]
    public string? parentPreferenceDesc { get; set; }

    [StringLength(20)]
    public string? consigneeTIN { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(26)]
    public string? periodCode { get; set; }

    public string? periodName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? periodStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? periodEndDateTime { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(50)]
    public string? LastObjectStateDesc { get; set; }

    [StringLength(26)]
    public string? color { get; set; }

    [StringLength(26)]
    public string? lastActivity { get; set; }

    [StringLength(26)]
    public string? userCode { get; set; }

    [StringLength(30)]
    public string? userName { get; set; }

    [StringLength(26)]
    public string? orgUnitDefCode { get; set; }

    [StringLength(26)]
    public string? deviceCode { get; set; }

    public string? deviceName { get; set; }

    public string? voucherNote { get; set; }

    [StringLength(26)]
    public string? sourceStoreCode { get; set; }

    [StringLength(50)]
    public string? sourceStoreName { get; set; }

    [StringLength(26)]
    public string? destinationStoreCode { get; set; }

    [StringLength(50)]
    public string? destinationStoreName { get; set; }

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
    public decimal? WithholdingTaxAmount { get; set; }

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
    public decimal? subTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? additionalCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal? discount { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string? fsNo { get; set; }

    [StringLength(26)]
    public string? mrsNo { get; set; }

    [StringLength(26)]
    public string? waiterCode { get; set; }

    public string? waiterName { get; set; }

    [StringLength(26)]
    public string? table { get; set; }

    [StringLength(26)]
    public string? cover { get; set; }

    public double latitude { get; set; }

    public double longitude { get; set; }

    public string? lastActivityDescription { get; set; }
}
