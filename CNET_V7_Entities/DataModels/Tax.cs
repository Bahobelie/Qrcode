using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Tax
{
    public int Id { get; set; }

    public int Code { get; set; }

    public int? Category { get; set; }

    public string? Description { get; set; }

    public double? Amount { get; set; }

    public string? Remark { get; set; }

    public virtual SystemConstant? CategoryNavigation { get; set; }

    public virtual ICollection<Gsltax> Gsltaxes { get; } = new List<Gsltax>();

    public virtual ICollection<ProgressTaxRate> ProgressTaxRates { get; } = new List<ProgressTaxRate>();

    public virtual ICollection<TaxTransaction> TaxTransactions { get; } = new List<TaxTransaction>();
}
