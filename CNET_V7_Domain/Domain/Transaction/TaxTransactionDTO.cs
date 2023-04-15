using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.TransactionSchema;
public partial class TaxTransactionDTO{
    public int Id { get; set; }
    public int Voucher { get; set; }
    public int? TaxType { get; set; }
    public decimal? TaxableAmount { get; set; }
    public decimal? TaxAmount { get; set; }
    public string? Remark { get; set; }
}
