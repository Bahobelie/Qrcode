using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Delegate
{
    public int Id { get; set; }

    public string? Delegating { get; set; }

    public string? Delegate1 { get; set; }

    public DateTime? StartTimeStamp { get; set; }

    public DateTime? EndTimeStamp { get; set; }

    public bool? IsActive { get; set; }

    public string? Remark { get; set; }
}
