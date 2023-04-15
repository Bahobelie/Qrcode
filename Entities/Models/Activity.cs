using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Activity", Schema = "common")]
[Index("code", Name = "IX_Activity", IsUnique = true)]
public partial class Activity
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? component { get; set; }

    /// <summary>
    /// Can Be:Article (common),Organization (common),Person (common),User (common),Voucher (common)
    /// </summary>
    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string activitiyDefinition { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime startTimStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? endTimStamp { get; set; }

    [StringLength(26)]
    public string? organizationUnitDef { get; set; }

    [StringLength(26)]
    public string? device { get; set; }

    [StringLength(26)]
    public string? user { get; set; }

    public int? year { get; set; }

    public int? month { get; set; }

    public int? date { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("activityNavigation")]
    public virtual ICollection<EffortConsumption> EffortConsumptions { get; } = new List<EffortConsumption>();

    [InverseProperty("activityNavigation")]
    public virtual ICollection<Log> Logs { get; } = new List<Log>();

    [InverseProperty("activityNavigation")]
    public virtual ICollection<ModificationHistory> ModificationHistories { get; } = new List<ModificationHistory>();

    [InverseProperty("activityNavigation")]
    public virtual ICollection<QCTest> QCTests { get; } = new List<QCTest>();

    [InverseProperty("activityNavigation")]
    public virtual ICollection<RemovedItem> RemovedItems { get; } = new List<RemovedItem>();

    [ForeignKey("activitiyDefinition")]
    [InverseProperty("Activities")]
    public virtual ActivityDefinition activitiyDefinitionNavigation { get; set; } = null!;

    [ForeignKey("component")]
    [InverseProperty("Activities")]
    public virtual CNETComponent? componentNavigation { get; set; }

    [ForeignKey("device")]
    [InverseProperty("Activities")]
    public virtual Device? deviceNavigation { get; set; }

    [ForeignKey("organizationUnitDef")]
    [InverseProperty("Activities")]
    public virtual OrganizationUnitDefinition? organizationUnitDefNavigation { get; set; }

    [ForeignKey("reference")]
    [InverseProperty("Activities")]
    public virtual Organization reference1 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("Activities")]
    public virtual Person reference2 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("Activities")]
    public virtual Voucher reference3 { get; set; } = null!;

    [ForeignKey("reference")]
    [InverseProperty("Activities")]
    public virtual Article referenceNavigation { get; set; } = null!;

    [ForeignKey("user")]
    [InverseProperty("Activities")]
    public virtual User? userNavigation { get; set; }
}
