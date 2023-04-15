using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class JournalDetailView
{
    [StringLength(26)]
    public string journalNumber { get; set; } = null!;

    [StringLength(26)]
    public string journalType { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string? period { get; set; }

    [StringLength(100)]
    public string? note { get; set; }

    [StringLength(26)]
    public string perCode { get; set; } = null!;

    [StringLength(26)]
    public string periodName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime startDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime endDate { get; set; }

    [StringLength(26)]
    public string? referening { get; set; }

    [StringLength(26)]
    public string? referenced { get; set; }

    [StringLength(26)]
    public string voucher { get; set; } = null!;

    [StringLength(26)]
    public string account { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal debit { get; set; }

    [Column(TypeName = "money")]
    public decimal credit { get; set; }

    [StringLength(26)]
    public string accCode { get; set; } = null!;

    [StringLength(26)]
    public string controlAccount { get; set; } = null!;

    [StringLength(50)]
    public string accDesc { get; set; } = null!;

    [StringLength(26)]
    public string? parentAccount { get; set; }

    public bool isActive { get; set; }

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(15)]
    public string normalBalance { get; set; } = null!;

    [StringLength(15)]
    public string accCategory { get; set; } = null!;
}
