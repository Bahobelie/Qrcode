using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Action", Schema = "common")]
[Index("Code", Name = "IX_Action", IsUnique = true)]
public partial class Action
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string Code { get; set; } = null!;

    [StringLength(26)]
    public string activityDefn { get; set; } = null!;

    [StringLength(26)]
    public string actionType { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [Column("action")]
    [StringLength(26)]
    public string action1 { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("activityDefn")]
    [InverseProperty("Actions")]
    public virtual ActivityDefinition activityDefnNavigation { get; set; } = null!;
}
