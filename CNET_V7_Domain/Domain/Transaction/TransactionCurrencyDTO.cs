using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.TransactionSchema;
public partial class TransactionCurrencyDTO{
    public int Id { get; set; }
    public int Voucher { get; set; }
    public int Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? Amount { get; set; }
    public decimal? Total { get; set; }
    public string? Remark { get; set; }
}
