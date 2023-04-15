using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.TransactionSchema;
public partial class LineItemConversionDTO{
    public int Id { get; set; }
    public int LineItem { get; set; }
    public int? Uom { get; set; }
    public decimal? Quantity { get; set; }
    public decimal? UnitAmount { get; set; }
    public string? Remark { get; set; }
}
