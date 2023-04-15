using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class DepreciationRule
{
    public int Id { get; set; }

    public string Preference { get; set; } = null!;

    public decimal StraightLine { get; set; }

    public decimal Declining { get; set; }

    public string? Remark { get; set; }
}
