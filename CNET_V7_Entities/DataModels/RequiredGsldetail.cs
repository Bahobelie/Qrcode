using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class RequiredGsldetail
{
    public int Id { get; set; }

    public int? RequiredGsl { get; set; }

    public int? GslType { get; set; }

    public int? ObjectState { get; set; }

    public int? Index { get; set; }

    public string? Remark { get; set; }

    public virtual SystemConstant? GslTypeNavigation { get; set; }

    public virtual ObjectStateDefinition? ObjectStateNavigation { get; set; }

    public virtual RequiredGsl? RequiredGslNavigation { get; set; }
}
