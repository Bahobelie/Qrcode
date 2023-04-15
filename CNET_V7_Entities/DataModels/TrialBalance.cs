using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class TrialBalance
{
    public int Id { get; set; }

    public string Account { get; set; } = null!;

    public int Period { get; set; }

    public decimal Debit { get; set; }

    public decimal Credit { get; set; }

    public string Type { get; set; } = null!;

    public int? ConsigneeUnit { get; set; }

    public string? Remark { get; set; }

    public virtual Period PeriodNavigation { get; set; } = null!;
}
