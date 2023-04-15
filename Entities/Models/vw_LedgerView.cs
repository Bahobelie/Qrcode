using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_LedgerView
{
    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string? consignee { get; set; }

    public int voucherDefinition { get; set; }

    [StringLength(26)]
    public string account { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? amt { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? debit { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? credit { get; set; }
}
