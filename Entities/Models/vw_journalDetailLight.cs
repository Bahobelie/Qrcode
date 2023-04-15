using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_journalDetailLight
{
    [StringLength(26)]
    public string journalDetailCode { get; set; } = null!;

    [StringLength(26)]
    public string journalNumber { get; set; } = null!;

    [StringLength(26)]
    public string journalType { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    public string? note { get; set; }

    [StringLength(26)]
    public string perCode { get; set; } = null!;

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
    public string controlAccount { get; set; } = null!;

    [StringLength(50)]
    public string accDesc { get; set; } = null!;

    [StringLength(26)]
    public string? parentAccount { get; set; }

    [StringLength(50)]
    public string controlAccDesc { get; set; } = null!;

    [StringLength(15)]
    public string normalBalance { get; set; } = null!;

    [StringLength(15)]
    public string accCategory { get; set; } = null!;

    [StringLength(50)]
    public string accType { get; set; } = null!;

    [StringLength(26)]
    public string? referencedconsignee { get; set; }

    [StringLength(100)]
    public string? groupingAccountType { get; set; }

    public int voucherDefinition { get; set; }

    public bool IsVoid { get; set; }

    [StringLength(26)]
    public string? branch { get; set; }

    [StringLength(26)]
    public string? vouchExtNumberOne { get; set; }
}
