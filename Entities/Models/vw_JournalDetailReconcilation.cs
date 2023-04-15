using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_JournalDetailReconcilation
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string account { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal debit { get; set; }

    [Column(TypeName = "money")]
    public decimal credit { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    public int? isReconciled { get; set; }

    [StringLength(26)]
    public string? ReconcilationCode { get; set; }

    [StringLength(26)]
    public string? reconcilationPeriod { get; set; }
}
