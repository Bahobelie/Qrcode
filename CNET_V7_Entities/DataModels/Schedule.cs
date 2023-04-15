using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Schedule
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public int? Pointer { get; set; }

    public string? Reference { get; set; }

    public int? ScheduledHeader { get; set; }

    public string? Remark { get; set; }

    public virtual SystemConstant? PointerNavigation { get; set; }

    public virtual ScheduleHeader? ScheduledHeaderNavigation { get; set; }

    public virtual ICollection<Value> Values { get; } = new List<Value>();
}
