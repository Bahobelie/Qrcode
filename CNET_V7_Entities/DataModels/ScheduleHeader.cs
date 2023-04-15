using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class ScheduleHeader
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int Cateogry { get; set; }

    public int Type { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public bool IsActive { get; set; }

    public string? Remark { get; set; }

    public virtual SystemConstant CateogryNavigation { get; set; } = null!;

    public virtual ICollection<MovieSchedule> MovieSchedules { get; } = new List<MovieSchedule>();

    public virtual ICollection<RouteAssignment> RouteAssignments { get; } = new List<RouteAssignment>();

    public virtual ICollection<ScheduleDetail> ScheduleDetails { get; } = new List<ScheduleDetail>();

    public virtual ICollection<Schedule> Schedules { get; } = new List<Schedule>();

    public virtual SystemConstant TypeNavigation { get; set; } = null!;
}
