using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class ProgressTaxRate
{
    public int Id { get; set; }

    public int? TaxCode { get; set; }

    public int? Range { get; set; }

    public string? Description { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Constant { get; set; }

    public string? Remark { get; set; }

    public virtual Range? RangeNavigation { get; set; }

    public virtual Tax? TaxCodeNavigation { get; set; }
}
