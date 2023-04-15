using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.TransactionSchema;
public partial class ClosedRelationDTO{
    public int Id { get; set; }
    public int Voucher { get; set; }
    public DateTime TimeStamp { get; set; }
    public int ReferredVouherDefn { get; set; }
    public int ReferringVoucherDefn { get; set; }
    public string? Remark { get; set; }
}
