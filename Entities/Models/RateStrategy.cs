using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("RateStrategy", Schema = "PMS")]
public partial class RateStrategy
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(150)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string condition { get; set; } = null!;

    [StringLength(26)]
    public string restrictionType { get; set; } = null!;

    public bool isPercent { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal value { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? startDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? endDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? controlBegin { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? controlEnd { get; set; }

    public int? priority { get; set; }

    public bool isActive { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [InverseProperty("rateStrategyNavigation")]
    public virtual ICollection<RateCategoryRateStrategy> RateCategoryRateStrategies { get; } = new List<RateCategoryRateStrategy>();

    [InverseProperty("rateStrategyNavigation")]
    public virtual ICollection<RateCodeRateStrategy> RateCodeRateStrategies { get; } = new List<RateCodeRateStrategy>();

    [InverseProperty("rateStrategyNavigation")]
    public virtual ICollection<RoomTypeRateStrategy> RoomTypeRateStrategies { get; } = new List<RoomTypeRateStrategy>();

    [InverseProperty("reference2")]
    public virtual ICollection<WeekDay> WeekDays { get; } = new List<WeekDay>();
}
