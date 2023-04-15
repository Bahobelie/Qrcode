using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class RelationalState
{
    public int Id { get; set; }

    public int Code { get; set; }

    public int? Relation { get; set; }

    public int? State { get; set; }

    public string? Criteria { get; set; }

    public string? Remark { get; set; }

    public virtual Relation? RelationNavigation { get; set; }

    public virtual ObjectStateDefinition? StateNavigation { get; set; }
}
