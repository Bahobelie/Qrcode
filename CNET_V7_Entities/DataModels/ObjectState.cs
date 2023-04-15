using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class ObjectState
{
    public int Id { get; set; }

    public int Code { get; set; }

    public int? Reference { get; set; }

    public int? ObjectStateDefinition { get; set; }

    public string? Remark { get; set; }

    public virtual ObjectStateDefinition IdNavigation { get; set; } = null!;
}
