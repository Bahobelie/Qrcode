using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("PlanDetail", Schema = "common")]
[Index("code", Name = "IX_PlanDetail", IsUnique = true)]
public partial class PlanDetail
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string plan { get; set; } = null!;

    [StringLength(26)]
    public string Type { get; set; } = null!;

    [StringLength(26)]
    public string component { get; set; } = null!;

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(40)]
    public string? resourceRole { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("plan")]
    [InverseProperty("PlanDetails")]
    public virtual Plan planNavigation { get; set; } = null!;
}
