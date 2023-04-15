using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.TransactionSchema;
public partial class NonCashTransactionDTO{
    public int Id { get; set; }
    public int Voucher { get; set; }
    public int? Consignee { get; set; }
    public bool? IsIncoming { get; set; }
    public int? PaymentMethod { get; set; }
    public string? PaymentProcessor { get; set; }
    public int? Index { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime? MaturityDate { get; set; }
    public string? Number { get; set; }
    public decimal? Amount { get; set; }
    public bool? Executed { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public string? Remark { get; set; }
}
