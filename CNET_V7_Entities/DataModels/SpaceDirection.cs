using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class SpaceDirection
{
    public int Id { get; set; }

    public int Device { get; set; }

    public int Space { get; set; }

    public string Direction { get; set; } = null!;

    public string? Remark { get; set; }

    public virtual Device DeviceNavigation { get; set; } = null!;

    public virtual Space SpaceNavigation { get; set; } = null!;
}
