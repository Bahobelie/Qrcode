using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.TransactionSchema;
public partial class VoucherAccountDTO{
    public int Id { get; set; }
    public int Voucher { get; set; }
    public string AccountCode { get; set; } = null!;
    public decimal? Amount { get; set; }
    public string? Remark { get; set; }
}
