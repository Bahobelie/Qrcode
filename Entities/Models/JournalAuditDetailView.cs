using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class JournalAuditDetailView
{
    [StringLength(26)]
    public string voucherCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalCredit { get; set; }

    [Column(TypeName = "money")]
    public decimal? totalDebit { get; set; }

    [Column(TypeName = "money")]
    public decimal? balance { get; set; }

    [StringLength(26)]
    public string journalType { get; set; } = null!;

    public bool IsIssued { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [StringLength(26)]
    public string? LastObjectState { get; set; }

    [StringLength(26)]
    public string? lastActivity { get; set; }
}
