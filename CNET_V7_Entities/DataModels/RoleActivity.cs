using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class RoleActivity
{
    public int Id { get; set; }

    public int Role { get; set; }

    public int ActivityDefinition { get; set; }

    public int? Range { get; set; }

    public string? Remark { get; set; }

    public virtual ActivityDefinition ActivityDefinitionNavigation { get; set; } = null!;

    public virtual Range? RangeNavigation { get; set; }

    public virtual ConsigneeUnit RoleNavigation { get; set; } = null!;
}
