using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class Voucher_BackwardReferenceReport_View
{
    [StringLength(26)]
    public string referringVouchCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime refferingIssuedDate { get; set; }

    [Column(TypeName = "money")]
    public decimal? referringAmt { get; set; }

    [Column(TypeName = "money")]
    public decimal referringTotal { get; set; }

    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    [StringLength(26)]
    public string transType { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? consigneeCode { get; set; }

    public string? consigneeName { get; set; }

    [StringLength(20)]
    public string? TIN { get; set; }

    [StringLength(26)]
    public string? consigneeChildCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }
}
