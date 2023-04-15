using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("ModificationHistory", Schema = "common")]
[Index("Code", Name = "IX_ModificationHistory", IsUnique = true)]
public partial class ModificationHistory
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string Code { get; set; } = null!;

    [StringLength(26)]
    public string activity { get; set; } = null!;

    [StringLength(26)]
    public string attribute { get; set; } = null!;

    [StringLength(50)]
    public string oldValue { get; set; } = null!;

    [StringLength(50)]
    public string newValue { get; set; } = null!;

    [StringLength(100)]
    public string? Remark { get; set; }

    [InverseProperty("referenceNavigation")]
    public virtual ICollection<CNET_GP> CNET_GPs { get; } = new List<CNET_GP>();

    [ForeignKey("activity")]
    [InverseProperty("ModificationHistories")]
    public virtual Activity activityNavigation { get; set; } = null!;
}
