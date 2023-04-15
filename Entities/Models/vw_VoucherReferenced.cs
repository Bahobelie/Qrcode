using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_VoucherReferenced
{
    public string name { get; set; } = null!;

    public string? CustomerName { get; set; }

    public string description { get; set; } = null!;

    [StringLength(26)]
    public string referenced { get; set; } = null!;

    [StringLength(26)]
    public string referening { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? value { get; set; }

    [StringLength(26)]
    public string article { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    public int? referencedTax { get; set; }

    public int? refereningTax { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? Dlvquantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? DlvunitAmt { get; set; }

    [Column(TypeName = "money")]
    public decimal? DlvtotalAmount { get; set; }

    public int referencedVt { get; set; }

    public int refereningVt { get; set; }

    [Column(TypeName = "money")]
    public decimal referencedgrandTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal refereninggrandTotal { get; set; }
}
