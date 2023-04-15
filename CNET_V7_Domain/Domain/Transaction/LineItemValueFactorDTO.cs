using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.TransactionSchema;
public partial class LineItemValueFactorDTO{
    public int Id { get; set; }
    public int? LineItem { get; set; }
    public int? ValueFactor { get; set; }
    public decimal? Amount { get; set; }
    public bool? IsDiscount { get; set; }
    public string? Remark { get; set; }
}
