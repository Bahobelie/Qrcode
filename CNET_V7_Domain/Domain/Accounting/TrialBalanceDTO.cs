using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.AccountingSchema;
public partial class TrialBalanceDTO{
    public int Id { get; set; }
    public string Account { get; set; } = null!;
    public int Period { get; set; }
    public decimal Debit { get; set; }
    public decimal Credit { get; set; }
    public string Type { get; set; } = null!;
    public int? ConsigneeUnit { get; set; }
    public string? Remark { get; set; }
}
