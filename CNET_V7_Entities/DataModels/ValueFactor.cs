using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class ValueFactor
{
    public int Id { get; set; }

    public int Code { get; set; }

    public string? Description { get; set; }

    public int? Pointer { get; set; }

    public int? Reference { get; set; }

    public int? ValueFactorDefinition { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<LineItemValueFactor> LineItemValueFactors { get; } = new List<LineItemValueFactor>();

    public virtual SystemConstant? PointerNavigation { get; set; }

    public virtual ValueFactorDefinition? ValueFactorDefinitionNavigation { get; set; }
}
