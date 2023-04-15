using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Relation
{
    public int Id { get; set; }

    public int Code { get; set; }

    public int? RelationType { get; set; }

    public int? ReferringObject { get; set; }

    public int? ReferencedObject { get; set; }

    public int? RelationLevel { get; set; }

    public string? Remark { get; set; }

    public virtual SystemConstant? RelationTypeNavigation { get; set; }

    public virtual ICollection<RelationalState> RelationalStates { get; } = new List<RelationalState>();
}
