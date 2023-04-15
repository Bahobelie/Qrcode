using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class ScheduleHeaderDTO{
    public int Id { get; set; }
    public string Description { get; set; } = null!;
    public int Cateogry { get; set; }
    public int Type { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsActive { get; set; }
    public string? Remark { get; set; }
}
