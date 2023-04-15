using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.TransactionSchema;
public partial class TransactionReferenceDTO{
    public int Id { get; set; }
    public int? Referring { get; set; }
    public int? ReferencingVoucherDefn { get; set; }
    public int? Referenced { get; set; }
    public int? ReferencedVoucherDefn { get; set; }
    public decimal? Value { get; set; }
    public int? RelationType { get; set; }
    public string? Remark { get; set; }
}
