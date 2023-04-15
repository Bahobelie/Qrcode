using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.ArticleSchema;
public partial class StockLevelDTO{
    public int Id { get; set; }
    public int? Article { get; set; }
    public int? Store { get; set; }
    public decimal? MinLevel { get; set; }
    public decimal? MaxLevel { get; set; }
    public int? LeadTimeDays { get; set; }
    public decimal? EconomicOrderQty { get; set; }
    public string? Remark { get; set; }
}
