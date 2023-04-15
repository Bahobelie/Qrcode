using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class RouteAssignment
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public int OrgUnit { get; set; }

    public int Space { get; set; }

    public int ScheduleHeader { get; set; }

    public string? Remark { get; set; }

    public virtual ConsigneeUnit OrgUnitNavigation { get; set; } = null!;

    public virtual ScheduleHeader ScheduleHeaderNavigation { get; set; } = null!;

    public virtual Space SpaceNavigation { get; set; } = null!;
}
