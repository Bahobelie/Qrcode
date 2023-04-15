using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class CheckoutDetailView
{
    public int voucherDefinition { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    [StringLength(26)]
    public string referening { get; set; } = null!;

    [StringLength(26)]
    public string referenced { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? unitAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? additionalCharge { get; set; }

    [StringLength(2048)]
    public string? note { get; set; }

    [Column(TypeName = "money")]
    public decimal? value { get; set; }

    [StringLength(50)]
    public string? relationType { get; set; }

    [StringLength(26)]
    public string tranRefCode { get; set; } = null!;
}
