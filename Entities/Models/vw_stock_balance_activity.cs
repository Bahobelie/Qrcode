using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_stock_balance_activity
{
    [StringLength(26)]
    public string stockBalanceCode { get; set; } = null!;

    [StringLength(26)]
    public string articleCode { get; set; } = null!;

    public string articleName { get; set; } = null!;

    [Column(TypeName = "decimal(18, 7)")]
    public decimal quantity { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string? period { get; set; }

    [StringLength(26)]
    public string preference { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? startTimStamp { get; set; }

    [StringLength(26)]
    public string? device { get; set; }

    [StringLength(26)]
    public string? user { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
