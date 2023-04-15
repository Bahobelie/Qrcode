using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class HolidayDTO{
    public int Id { get; set; }
    public int HolidayDefinition { get; set; }
    public int? ForecastedPeriod { get; set; }
    public int ActualPeriod { get; set; }
    public string? Remark { get; set; }
}
