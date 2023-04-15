using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class JournalReferenceAuditView
{
    [StringLength(26)]
    public string jvCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime jvIssueDate { get; set; }

    [StringLength(26)]
    public string? jvPeriod { get; set; }

    [StringLength(26)]
    public string? referening { get; set; }

    [StringLength(26)]
    public string? referenced { get; set; }

    [StringLength(26)]
    public string type { get; set; } = null!;
}
