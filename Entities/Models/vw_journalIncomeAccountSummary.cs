using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_journalIncomeAccountSummary
{
    [StringLength(26)]
    public string jvVoucher { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime jvDate { get; set; }

    [StringLength(26)]
    public string? jvPeriod { get; set; }

    [StringLength(26)]
    public string jvType { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? debit { get; set; }

    [Column(TypeName = "money")]
    public decimal? credit { get; set; }

    [Column(TypeName = "money")]
    public decimal? jvTotal { get; set; }

    [StringLength(26)]
    public string referenced { get; set; } = null!;
}
