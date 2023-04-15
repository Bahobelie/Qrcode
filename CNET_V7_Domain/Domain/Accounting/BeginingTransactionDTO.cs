using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.AccountingSchema;
public partial class BeginingTransactionDTO{
    public int Id { get; set; }
    public string Account { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string? Reference { get; set; }
    public DateTime Date { get; set; }
    public string Period { get; set; } = null!;
    public int Type { get; set; }
    public decimal Amount { get; set; }
    public int Reconciled { get; set; }
    public string ReconciliationPeriod { get; set; } = null!;
    public string? Remark { get; set; }
}
