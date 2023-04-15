using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("ReconciliationSummary", Schema = "common")]
[Index("code", Name = "IX_ReconciliationSummary", IsUnique = true)]
public partial class ReconciliationSummary
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string name { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string comparision { get; set; } = null!;

    [StringLength(26)]
    public string comparisionType { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("reconSumNavigation")]
    public virtual ICollection<ReconciliationDetail> ReconciliationDetails { get; } = new List<ReconciliationDetail>();

    [ForeignKey("comparision")]
    [InverseProperty("ReconciliationSummarycomparisionNavigations")]
    public virtual Lookup comparisionNavigation { get; set; } = null!;

    [ForeignKey("comparisionType")]
    [InverseProperty("ReconciliationSummarycomparisionTypeNavigations")]
    public virtual Lookup comparisionTypeNavigation { get; set; } = null!;
}
