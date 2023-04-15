using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Configuration
{
    public int Id { get; set; }

    public int? Reference { get; set; }

    public string? Attribute { get; set; }

    public string? CurrentValue { get; set; }

    public string? PreviousValue { get; set; }

    public int? Preference { get; set; }

    public string? Remark { get; set; }
}
