using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class StockBalance
{
    public int Id { get; set; }

    public int? Article { get; set; }

    public int? Period { get; set; }

    public int? Type { get; set; }

    public int? Store { get; set; }

    public int? Uom { get; set; }

    public decimal? Quantity { get; set; }

    public string? Remark { get; set; }

    public virtual Article? ArticleNavigation { get; set; }

    public virtual Period? PeriodNavigation { get; set; }

    public virtual ConsigneeUnit? StoreNavigation { get; set; }

    public virtual Lookup? UomNavigation { get; set; }
}
