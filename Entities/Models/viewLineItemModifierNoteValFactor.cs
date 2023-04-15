using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class viewLineItemModifierNoteValFactor
{
    [StringLength(26)]
    public string LineItemCode { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    public int? tax { get; set; }

    [Column(TypeName = "money")]
    public decimal? taxAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? calculatedCost { get; set; }

    [StringLength(100)]
    public string? LIremark { get; set; }

    [StringLength(26)]
    public string? LMcode { get; set; }

    [StringLength(26)]
    public string? articleModfier { get; set; }

    [StringLength(100)]
    public string? LMremark { get; set; }

    [StringLength(26)]
    public string? LNcode { get; set; }

    public string? note { get; set; }

    public bool? overrideArticleDescription { get; set; }

    [StringLength(100)]
    public string? LNremerk { get; set; }

    [StringLength(26)]
    public string? LVFcode { get; set; }

    [StringLength(26)]
    public string? valueFactorReference { get; set; }

    public bool? isDiscount { get; set; }

    [Column(TypeName = "money")]
    public decimal? amount { get; set; }

    [StringLength(100)]
    public string? LVFremark { get; set; }
}
