using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Holiday
{
    public int Id { get; set; }

    public int HolidayDefinition { get; set; }

    public int? ForecastedPeriod { get; set; }

    public int ActualPeriod { get; set; }

    public string? Remark { get; set; }

    public virtual Period ActualPeriodNavigation { get; set; } = null!;

    public virtual Period? ForecastedPeriodNavigation { get; set; }

    public virtual HolidayDefinition HolidayDefinitionNavigation { get; set; } = null!;
}
