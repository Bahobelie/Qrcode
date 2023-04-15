using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RoleActivity", Schema = "common")]
[Index("code", Name = "IX_RoleActivity", IsUnique = true)]
public partial class RoleActivity
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string role { get; set; } = null!;

    [StringLength(26)]
    public string activityDefinition { get; set; } = null!;

    public bool needsPassCode { get; set; }

    [StringLength(26)]
    public string? range { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("roleNavigation")]
    public virtual ICollection<UserRoleMapper> UserRoleMappers { get; } = new List<UserRoleMapper>();

    [ForeignKey("activityDefinition")]
    [InverseProperty("RoleActivities")]
    public virtual ActivityDefinition activityDefinitionNavigation { get; set; } = null!;
}
