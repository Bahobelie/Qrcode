using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ShiftClosing
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? subTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? discount { get; set; }

    [Column(TypeName = "money")]
    public decimal? additionalCharge { get; set; }

    [StringLength(26)]
    public string? device { get; set; }

    [StringLength(26)]
    public string? UserCode { get; set; }

    [StringLength(26)]
    public string? fsNo { get; set; }

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
    public decimal? taxAmount { get; set; }

    [StringLength(26)]
    public string? organizationUnitDefinition { get; set; }
}
