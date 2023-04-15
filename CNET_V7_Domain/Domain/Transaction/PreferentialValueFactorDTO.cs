using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.TransactionSchema;
public partial class PreferentialValueFactorDTO{
    public int Id { get; set; }
    public int Voucher { get; set; }
    public int? Preference { get; set; }
    public int? ValueFactorDefn { get; set; }
    public decimal? Amount { get; set; }
    public string? Remark { get; set; }
}
