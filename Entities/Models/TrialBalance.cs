using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("TrialBalance", Schema = "common")]
[Index("code", Name = "IX_TrialBalance", IsUnique = true)]
public partial class TrialBalance
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string account { get; set; } = null!;

    [StringLength(26)]
    public string period { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal debit { get; set; }

    [Column(TypeName = "money")]
    public decimal credit { get; set; }

    [StringLength(50)]
    public string type { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("period")]
    [InverseProperty("TrialBalances")]
    public virtual Period periodNavigation { get; set; } = null!;
}
