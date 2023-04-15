using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class SeatTransaction
{
    public int Id { get; set; }

    public int Lineitem { get; set; }

    public int Movieschedule { get; set; }

    public int Seatarrangement { get; set; }

    public int Voudef { get; set; }

    public string? Remark { get; set; }

    public virtual LineItem LineitemNavigation { get; set; } = null!;

    public virtual MovieSchedule MoviescheduleNavigation { get; set; } = null!;

    public virtual SeatArrangement SeatarrangementNavigation { get; set; } = null!;

    public virtual SystemConstant VoudefNavigation { get; set; } = null!;
}
