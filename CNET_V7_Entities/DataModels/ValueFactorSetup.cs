using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class ValueFactorSetup
{
    public int Id { get; set; }

    public int? ValueFactorDefinition { get; set; }

    public int? VoucherDefinition { get; set; }

    public string? Source { get; set; }

    public string? Destination { get; set; }

    public string? Remark { get; set; }

    public virtual ValueFactorDefinition? ValueFactorDefinitionNavigation { get; set; }

    public virtual SystemConstant? VoucherDefinitionNavigation { get; set; }
}
