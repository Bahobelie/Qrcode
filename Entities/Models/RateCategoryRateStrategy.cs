using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RateCategoryRateStrategy", Schema = "PMS")]
public partial class RateCategoryRateStrategy
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string? rateCategory { get; set; }

    [StringLength(26)]
    public string? rateStrategy { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("rateCategory")]
    [InverseProperty("RateCategoryRateStrategies")]
    public virtual RateCategory? rateCategoryNavigation { get; set; }

    [ForeignKey("rateStrategy")]
    [InverseProperty("RateCategoryRateStrategies")]
    public virtual RateStrategy? rateStrategyNavigation { get; set; }
}
