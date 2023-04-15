using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("ReportCriteria", Schema = "common")]
[Index("code", Name = "IX_ReportCriteria", IsUnique = true)]
public partial class ReportCriterion
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string report { get; set; } = null!;

    [StringLength(20)]
    public string? component { get; set; }

    [StringLength(50)]
    public string? description { get; set; }

    public byte? Index { get; set; }

    [StringLength(26)]
    public string? controlType { get; set; }

    public bool IsActive { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("controlType")]
    [InverseProperty("ReportCriteria")]
    public virtual Lookup? controlTypeNavigation { get; set; }
}
