using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RateCategory", Schema = "PMS")]
public partial class RateCategory
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? startDate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? endDate { get; set; }

    [StringLength(26)]
    public string? parent { get; set; }

    [StringLength(26)]
    public string? type { get; set; }

    public string? ratePolicy { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("parentNavigation")]
    public virtual ICollection<RateCategory> InverseparentNavigation { get; } = new List<RateCategory>();

    [InverseProperty("rateCategoryNavigation")]
    public virtual ICollection<RateCategoryRateStrategy> RateCategoryRateStrategies { get; } = new List<RateCategoryRateStrategy>();

    [ForeignKey("parent")]
    [InverseProperty("InverseparentNavigation")]
    public virtual RateCategory? parentNavigation { get; set; }
}
