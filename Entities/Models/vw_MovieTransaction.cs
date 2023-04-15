using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_MovieTransaction
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string moviecode { get; set; } = null!;

    [StringLength(26)]
    public string mediacode { get; set; } = null!;

    [StringLength(50)]
    public string name { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string? article { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    public int? tax { get; set; }

    [Column(TypeName = "money")]
    public decimal taxableAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? taxAmount { get; set; }

    public bool IsIssued { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string? movielanguage { get; set; }

    [StringLength(26)]
    public string? subtitlelanguage { get; set; }

    [StringLength(26)]
    public string movieCategory { get; set; } = null!;

    public string? producer { get; set; }
}
