using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.TransactionSchema;
public partial class LineItemReferenceDTO{
    public int Id { get; set; }
    public int LineItem { get; set; }
    public int? Voucher { get; set; }
    public int? ReferencedVouDfn { get; set; }
    public int? Referenced { get; set; }
    public decimal? Value { get; set; }
    public string? Remark { get; set; }
}
