using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class StockLevel
{
    public int Id { get; set; }

    public int? Article { get; set; }

    public int? Store { get; set; }

    public decimal? MinLevel { get; set; }

    public decimal? MaxLevel { get; set; }

    public int? LeadTimeDays { get; set; }

    public decimal? EconomicOrderQty { get; set; }

    public string? Remark { get; set; }

    public virtual Article? ArticleNavigation { get; set; }

    public virtual ConsigneeUnit? StoreNavigation { get; set; }
}
