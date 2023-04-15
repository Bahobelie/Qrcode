using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherDetailWithTransactionReference
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string referenced { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [Column(TypeName = "money")]
    public decimal? value { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(50)]
    public string? parentDescription { get; set; }

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    public bool IsIssued { get; set; }

    [StringLength(26)]
    public string? parent { get; set; }
}
