using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.AccountingSchema;
public partial class AccountMapDTO{
    public int Id { get; set; }
    public string Reference { get; set; } = null!;
    public int ConsigneeUnit { get; set; }
    public string? Description { get; set; }
    public string Account { get; set; } = null!;
    public string? Remark { get; set; }
}
