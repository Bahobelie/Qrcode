using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class PackageToPost_View
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }

    [StringLength(26)]
    public string? packageHeader { get; set; }

    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal amount { get; set; }

    [StringLength(26)]
    public string registrationDetail { get; set; } = null!;

    [StringLength(26)]
    public string? calculationRule { get; set; }

    [StringLength(26)]
    public string? formula { get; set; }

    [StringLength(26)]
    public string? packageCurrency { get; set; }

    public bool? sellSeparate { get; set; }

    [StringLength(26)]
    public string? postingRhythm { get; set; }

    [StringLength(26)]
    public string? rateApearance { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }
}
