using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.AccountingSchema;
public partial class AccountDTO{
    public int Id { get; set; }
    public string Code { get; set; } = null!;
    public int ControlAccount { get; set; }
    public string Description { get; set; } = null!;
    public bool IsActive { get; set; }
    public string? ParentAccount { get; set; }
    public string? Remark { get; set; }
}
