using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class OrderStationMap
{
    public int Id { get; set; }

    public int PosDevice { get; set; }

    public int Preference { get; set; }

    public int StationDevice { get; set; }

    public string? Remark { get; set; }

    public virtual Device PosDeviceNavigation { get; set; } = null!;

    public virtual Preference PreferenceNavigation { get; set; } = null!;

    public virtual Device StationDeviceNavigation { get; set; } = null!;
}
