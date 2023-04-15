using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class ReconciliationSummary
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Comparision { get; set; }

    public int ComparisionType { get; set; }

    public string? Remark { get; set; }

    public virtual SystemConstant ComparisionNavigation { get; set; } = null!;

    public virtual SystemConstant ComparisionTypeNavigation { get; set; } = null!;

    public virtual ICollection<ReconciliationDetail> ReconciliationDetails { get; } = new List<ReconciliationDetail>();
}
