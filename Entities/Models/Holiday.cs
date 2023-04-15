using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Table("Holiday", Schema = "common")]
[Index("code", Name = "IX_Holiday", IsUnique = true)]
public partial class Holiday
{
    public Guid id { get; set; }

    [Key]
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string holidayDfn { get; set; } = null!;

    [StringLength(26)]
    public string? forecastedPeriod { get; set; }

    [StringLength(26)]
    public string actualPeriod { get; set; } = null!;

    [StringLength(100)]
    public string? remark { get; set; }

    [ForeignKey("actualPeriod")]
    [InverseProperty("HolidayactualPeriodNavigations")]
    public virtual Period actualPeriodNavigation { get; set; } = null!;

    [ForeignKey("forecastedPeriod")]
    [InverseProperty("HolidayforecastedPeriodNavigations")]
    public virtual Period? forecastedPeriodNavigation { get; set; }

    [ForeignKey("holidayDfn")]
    [InverseProperty("Holidays")]
    public virtual HolidayDefinition holidayDfnNavigation { get; set; } = null!;
}
