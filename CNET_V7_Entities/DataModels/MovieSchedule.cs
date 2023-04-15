using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class MovieSchedule
{
    public int Id { get; set; }

    public int OrgUnit { get; set; }

    public int Reference { get; set; }

    public int Space { get; set; }

    public int ScheduleHeader { get; set; }

    public int? Dimension { get; set; }

    public decimal Value { get; set; }

    public string? Remark { get; set; }

    public virtual SystemConstant? DimensionNavigation { get; set; }

    public virtual ConsigneeUnit OrgUnitNavigation { get; set; } = null!;

    public virtual ScheduleHeader ScheduleHeaderNavigation { get; set; } = null!;

    public virtual ICollection<SeatTransaction> SeatTransactions { get; } = new List<SeatTransaction>();

    public virtual Space SpaceNavigation { get; set; } = null!;
}
