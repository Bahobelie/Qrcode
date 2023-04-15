using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class ScheduleDTO{
    public int Id { get; set; }
    public string? Description { get; set; }
    public int? Pointer { get; set; }
    public string? Reference { get; set; }
    public int? ScheduledHeader { get; set; }
    public string? Remark { get; set; }
}
