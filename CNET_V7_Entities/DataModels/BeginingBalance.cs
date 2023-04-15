using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class BeginingBalance
{
    public int Id { get; set; }

    public int Code { get; set; }

    public int? Reference { get; set; }

    public int? Period { get; set; }

    public decimal? Value { get; set; }

    public bool? IsProvisional { get; set; }

    public string? Remark { get; set; }

    public virtual Period? PeriodNavigation { get; set; }
}
