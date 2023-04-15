using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_EventRequirementView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? voucher { get; set; }

    [StringLength(26)]
    public string article { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? unitAmt { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal quantity { get; set; }

    [StringLength(26)]
    public string? eventDetail { get; set; }

    public string artName { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    public string? LineItemNote { get; set; }

    public string? VoucherNote { get; set; }
}
