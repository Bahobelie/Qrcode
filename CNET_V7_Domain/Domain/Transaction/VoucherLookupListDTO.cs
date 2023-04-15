using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.TransactionSchema;
public partial class VoucherLookupListDTO{
    public int Id { get; set; }
    public int Voucher { get; set; }
    public int? SelectedLookup { get; set; }
    public string? Remark { get; set; }
}
