using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.TransactionSchema;
public partial class VoucherTermDTO{
    public int Id { get; set; }
    public int Voucher { get; set; }
    public int Term { get; set; }
    public string? Value { get; set; }
    public string? Remark { get; set; }
}
