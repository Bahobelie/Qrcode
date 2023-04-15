using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Report
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public int Index { get; set; }

    public int Pointer { get; set; }

    public int Category { get; set; }

    public int ReportType { get; set; }

    public string? Reference { get; set; }

    public string DefaultName { get; set; } = null!;

    public string? CustomName { get; set; }

    public string Description { get; set; } = null!;

    public bool IsActive { get; set; }

    public string? Url { get; set; }

    public string? Remark { get; set; }

    public virtual SystemConstant CategoryNavigation { get; set; } = null!;

    public virtual SystemConstant PointerNavigation { get; set; } = null!;

    public virtual SystemConstant ReportTypeNavigation { get; set; } = null!;
}
