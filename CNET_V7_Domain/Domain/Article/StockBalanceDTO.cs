using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.ArticleSchema;
public partial class StockBalanceDTO{
    public int Id { get; set; }
    public int? Article { get; set; }
    public int? Period { get; set; }
    public int? Type { get; set; }
    public int? Store { get; set; }
    public int? Uom { get; set; }
    public decimal? Quantity { get; set; }
    public string? Remark { get; set; }
}
