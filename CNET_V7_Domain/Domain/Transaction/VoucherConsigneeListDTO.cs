using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.TransactionSchema;
public partial class VoucherConsigneeListDTO{
    public int Id { get; set; }
    public int Voucher { get; set; }
    public int Consignee { get; set; }
    public int? Type { get; set; }
    public string? Remark { get; set; }
}
