using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.ConsigneeSchema;
public partial class TransactionLimitDTO{
    public int Id { get; set; }
    public int? Consignee { get; set; }
    public string? Description { get; set; }
    public int? Type { get; set; }
    public int? LimitFactor { get; set; }
    public string? Value { get; set; }
    public string? Remark { get; set; }
}
