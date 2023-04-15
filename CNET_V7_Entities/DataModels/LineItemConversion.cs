using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class LineItemConversion
{
    public int Id { get; set; }

    public int LineItem { get; set; }

    public int? Uom { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? UnitAmount { get; set; }

    public string? Remark { get; set; }

    public virtual LineItem LineItemNavigation { get; set; } = null!;

    public virtual SystemConstant? UomNavigation { get; set; }
}
