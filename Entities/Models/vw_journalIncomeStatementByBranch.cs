using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_journalIncomeStatementByBranch
{
    [StringLength(26)]
    public string journalDetailCode { get; set; } = null!;

    [StringLength(26)]
    public string journalNumber { get; set; } = null!;

    [StringLength(26)]
    public string journalType { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [StringLength(26)]
    public string account { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string controlAccount { get; set; } = null!;

    [StringLength(26)]
    public string? parentAccount { get; set; }

    [Column(TypeName = "money")]
    public decimal debit { get; set; }

    [Column(TypeName = "money")]
    public decimal credit { get; set; }

    [StringLength(26)]
    public string branch { get; set; } = null!;

    [StringLength(100)]
    public string? groupingAccountType { get; set; }
}
