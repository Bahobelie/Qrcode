using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherTaxSummaryWithTransactionReference
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string referening { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public bool? IsIssued { get; set; }

    [Column(TypeName = "money")]
    public decimal? taxAmount { get; set; }
}
