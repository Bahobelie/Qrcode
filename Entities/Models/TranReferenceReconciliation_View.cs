using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class TranReferenceReconciliation_View
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int voucherDefinition { get; set; }

    [Column(TypeName = "money")]
    public decimal grandTotal { get; set; }

    public bool isDebit { get; set; }

    [StringLength(2048)]
    public string? note { get; set; }

    [StringLength(26)]
    public string referenced { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(50)]
    public string name { get; set; } = null!;

    [StringLength(100)]
    public string? TranRefRemark { get; set; }

    [StringLength(50)]
    public string? relationType { get; set; }

    [StringLength(26)]
    public string comparisionType { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? TranRefValue { get; set; }
}
