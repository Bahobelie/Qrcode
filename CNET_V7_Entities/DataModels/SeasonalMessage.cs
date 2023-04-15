using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class SeasonalMessage
{
    public int Id { get; set; }

    public string Message { get; set; } = null!;

    public int Period { get; set; }

    public string? Font { get; set; }

    public string? Remark { get; set; }

    public virtual Period PeriodNavigation { get; set; } = null!;
}
