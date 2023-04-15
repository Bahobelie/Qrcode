using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class ViewHolidayPeriod
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string holidayDfn { get; set; } = null!;

    [StringLength(50)]
    public string? HolidayDesc { get; set; }

    [StringLength(26)]
    public string? forecastedPeriod { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ForcastPeriodStart { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ForcastPeriodEnd { get; set; }

    [StringLength(26)]
    public string actualPeriod { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? ActualPeriodStart { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ActualPeriodEnd { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
