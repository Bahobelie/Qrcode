using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_groupedNonCashTransaction
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? totalAmount { get; set; }

    public string? number { get; set; }
}
