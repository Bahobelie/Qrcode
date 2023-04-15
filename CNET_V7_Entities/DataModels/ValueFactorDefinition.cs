using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class ValueFactorDefinition
{
    public int Id { get; set; }

    public int Code { get; set; }

    public int? Type { get; set; }

    public string? Description { get; set; }

    public bool? IsPercent { get; set; }

    public decimal? Value { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<DiscountFactor> DiscountFactors { get; } = new List<DiscountFactor>();

    public virtual ICollection<PreferentialValueFactor> PreferentialValueFactors { get; } = new List<PreferentialValueFactor>();

    public virtual SystemConstant? TypeNavigation { get; set; }

    public virtual ICollection<ValueFactorSetup> ValueFactorSetups { get; } = new List<ValueFactorSetup>();

    public virtual ICollection<ValueFactor> ValueFactors { get; } = new List<ValueFactor>();
}
