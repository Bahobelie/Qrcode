using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherReferenceSummary
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(26)]
    public string referening { get; set; } = null!;

    [StringLength(26)]
    public string referenced { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? consumed { get; set; }
}
