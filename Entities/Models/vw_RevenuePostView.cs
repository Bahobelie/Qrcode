using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_RevenuePostView
{
    [StringLength(26)]
    public string sourceVoucher { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime sourceIssueDate { get; set; }

    [Column(TypeName = "money")]
    public decimal sourceGrandTotal { get; set; }

    [StringLength(26)]
    public string? sourcePeriod { get; set; }

    [StringLength(100)]
    public string? name { get; set; }

    [StringLength(15)]
    public string? journalType { get; set; }

    [Column(TypeName = "money")]
    public decimal? subTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal? additionalCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalRevenue { get; set; }

    [StringLength(26)]
    public string jdCode { get; set; } = null!;

    [StringLength(26)]
    public string? jvCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? jvDate { get; set; }

    [Column(TypeName = "money")]
    public decimal? jvGrandTotal { get; set; }

    [StringLength(26)]
    public string? jvPeriod { get; set; }

    [StringLength(26)]
    public string? account { get; set; }

    [StringLength(50)]
    public string? accountDescription { get; set; }

    [StringLength(26)]
    public string? controlAccount { get; set; }

    [Column(TypeName = "money")]
    public decimal? debit { get; set; }

    [Column(TypeName = "money")]
    public decimal? credit { get; set; }

    [Column(TypeName = "money")]
    public decimal? jvTotal { get; set; }

    [StringLength(26)]
    public string? referenced { get; set; }

    [StringLength(26)]
    public string? jvType { get; set; }

    [Column(TypeName = "money")]
    public decimal? discount { get; set; }
}
