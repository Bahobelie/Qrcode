using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Plan", Schema = "common")]
[Index("code", Name = "IX_Plan", IsUnique = true)]
public partial class Plan
{
    public Guid Id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string period { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? value { get; set; }

    [StringLength(26)]
    public string? rating { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("planNavigation")]
    public virtual ICollection<PlanDetail> PlanDetails { get; } = new List<PlanDetail>();

    [ForeignKey("period")]
    [InverseProperty("Plans")]
    public virtual Period periodNavigation { get; set; } = null!;

    [ForeignKey("rating")]
    [InverseProperty("PlanratingNavigations")]
    public virtual Lookup? ratingNavigation { get; set; }

    [ForeignKey("type")]
    [InverseProperty("PlantypeNavigations")]
    public virtual Lookup typeNavigation { get; set; } = null!;
}
