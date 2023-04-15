using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class ScheduleDetailDTO{
    public int Id { get; set; }
    public int Seheduleheader { get; set; }
    public string? DayMonth { get; set; }
    public string? StartTime { get; set; }
    public string? EndTime { get; set; }
    public byte? DayOfMonth { get; set; }
    public string? Remark { get; set; }
}
