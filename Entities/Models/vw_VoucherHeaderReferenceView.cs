using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherHeaderReferenceView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    public string? Name { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public int taxType { get; set; }

    [Column(TypeName = "money")]
    public decimal taxableAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal taxAmount { get; set; }

    public string? vouchNote { get; set; }

    [Column(TypeName = "money")]
    public decimal otherTaxAmt { get; set; }

    [Column(TypeName = "money")]
    public decimal? grandTotal { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    [Column(TypeName = "money")]
    public decimal? GTotal { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    public int? referredVoucherDefn { get; set; }

    public int? referringVoucherDefn { get; set; }

    [StringLength(26)]
    public string? lastActivity { get; set; }

    [StringLength(26)]
    public string? user { get; set; }

    [StringLength(30)]
    public string? userName { get; set; }

    [StringLength(26)]
    public string? Reference { get; set; }

    [StringLength(26)]
    public string? vouchExtNumberOne { get; set; }

    [StringLength(26)]
    public string? organizationUnitDef { get; set; }
}
