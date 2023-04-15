using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.AccountingSchema;
public partial class ControlAccountDTO{
    public int Id { get; set; }
    public string Description { get; set; } = null!;
    public string NormalBalance { get; set; } = null!;
    public string AccCategory { get; set; } = null!;
    public string AccType { get; set; } = null!;
    public string? Remark { get; set; }
}
