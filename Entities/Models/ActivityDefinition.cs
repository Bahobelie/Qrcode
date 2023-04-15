using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("ActivityDefinition", Schema = "common")]
[Index("code", Name = "IX_ActivityDefinition", IsUnique = true)]
public partial class ActivityDefinition
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? component { get; set; }

    [StringLength(26)]
    public string? reference { get; set; }

    [StringLength(26)]
    public string description { get; set; } = null!;

    public byte Index { get; set; }

    public bool hasIssuingEffect { get; set; }

    public bool isManual { get; set; }

    [StringLength(26)]
    public string? timeFactor { get; set; }

    public int? requiredTime { get; set; }

    public int? maxRepeat { get; set; }

    public bool? sequence { get; set; }

    public bool? isPrint { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("activityDefnNavigation")]
    public virtual ICollection<Action> Actions { get; } = new List<Action>();

    [InverseProperty("activitiyDefinitionNavigation")]
    public virtual ICollection<Activity> Activities { get; } = new List<Activity>();

    [InverseProperty("activityDefinitionNavigation")]
    public virtual ICollection<RoleActivity> RoleActivities { get; } = new List<RoleActivity>();
}
