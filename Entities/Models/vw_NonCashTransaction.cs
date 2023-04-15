using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_NonCashTransaction
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(64)]
    public string? name { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsIssued { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(26)]
    public string? device { get; set; }

    [StringLength(26)]
    public string? user { get; set; }

    [StringLength(30)]
    public string? userName { get; set; }

    [StringLength(50)]
    public string? orgUintDefDescription { get; set; }

    [StringLength(26)]
    public string? organizationUnitDef { get; set; }

    [Column(TypeName = "money")]
    public decimal? subTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? discount { get; set; }

    [Column(TypeName = "money")]
    public decimal? additionalCharge { get; set; }

    [StringLength(50)]
    public string? ObjectStateDescription { get; set; }

    [StringLength(26)]
    public string? source { get; set; }

    [StringLength(26)]
    public string? destination { get; set; }

    [StringLength(50)]
    public string? sourceName { get; set; }

    [StringLength(50)]
    public string? destinationName { get; set; }

    [StringLength(2048)]
    public string? note { get; set; }

    [Column(TypeName = "money")]
    public decimal? Tax { get; set; }

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? ObjectStateDefCode { get; set; }

    public string? DeviceName { get; set; }

    [StringLength(26)]
    public string? periodName { get; set; }

    [StringLength(26)]
    public string? requiredGSL { get; set; }

    [StringLength(26)]
    public string? otherConsigneeCode { get; set; }

    [StringLength(26)]
    public string referenced { get; set; } = null!;

    [StringLength(26)]
    public string referening { get; set; } = null!;

    [StringLength(26)]
    public string? paymentMethod { get; set; }

    [StringLength(50)]
    public string? paymentMethodDes { get; set; }

    [StringLength(26)]
    public string? currencyCode { get; set; }

    [StringLength(50)]
    public string? currencyName { get; set; }

    [Column(TypeName = "money")]
    public decimal? rate { get; set; }

    [Column(TypeName = "money")]
    public decimal? amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? total { get; set; }

    [StringLength(50)]
    public string? tradeName { get; set; }

    [StringLength(50)]
    public string? brandName { get; set; }

    public int? referingVouDefn { get; set; }

    public bool? referingVouIsIssued { get; set; }

    public bool? referingVouIsVoid { get; set; }

    [Column(TypeName = "money")]
    public decimal? referingVougrandTotal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? referingVouchIssuedDate { get; set; }
}
