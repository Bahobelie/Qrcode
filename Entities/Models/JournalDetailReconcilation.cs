using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("JournalDetailReconcilation", Schema = "common")]
public partial class JournalDetailReconcilation
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string journalDetail { get; set; } = null!;

    public int isReconciled { get; set; }

    [StringLength(26)]
    public string reconcilationPeriod { get; set; } = null!;

    public string? remark { get; set; }

    [ForeignKey("journalDetail")]
    [InverseProperty("JournalDetailReconcilations")]
    public virtual JournalDetail journalDetailNavigation { get; set; } = null!;
}
