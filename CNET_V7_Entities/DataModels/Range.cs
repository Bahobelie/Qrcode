using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Range
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int? Type { get; set; }

    public decimal Min { get; set; }

    public decimal Max { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<DiscountFactor> DiscountFactors { get; } = new List<DiscountFactor>();

    public virtual ICollection<ProgressTaxRate> ProgressTaxRates { get; } = new List<ProgressTaxRate>();

    public virtual ICollection<RoleActivity> RoleActivities { get; } = new List<RoleActivity>();

    public virtual SystemConstant? TypeNavigation { get; set; }
}
