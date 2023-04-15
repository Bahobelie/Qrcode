using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ServiceLineItemExtDetail
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    public string articleName { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal taxableAmount { get; set; }

    public int? tax { get; set; }

    [Column(TypeName = "money")]
    public decimal? taxAmount { get; set; }

    [StringLength(26)]
    public string lineItemExtOne { get; set; } = null!;

    [StringLength(50)]
    public string lineItemExtDescOne { get; set; } = null!;

    public string lineItemExtNumberOne { get; set; } = null!;

    [StringLength(26)]
    public string? lineItemExtSecond { get; set; }

    [StringLength(50)]
    public string? lineItemExtDescSecond { get; set; }

    public string? lineItemExtNumberSecond { get; set; }

    [StringLength(26)]
    public string? lineItemExtThird { get; set; }

    [StringLength(50)]
    public string? lineItemExtDescThird { get; set; }

    public string? lineItemExtNumberThird { get; set; }

    [StringLength(26)]
    public string? lineItemExtFourth { get; set; }

    [StringLength(50)]
    public string? lineItemExtDescFourth { get; set; }

    public string? lineItemExtNumberFourth { get; set; }

    [StringLength(26)]
    public string? referenced { get; set; }

    [StringLength(26)]
    public string? jobcardLineItemCode { get; set; }
}
