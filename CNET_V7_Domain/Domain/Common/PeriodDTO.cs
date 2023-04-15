using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class PeriodDTO{
    public int Id { get; set; }
    public string PeriodName { get; set; } = null!;
    public int Type { get; set; }
    public int? Category { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string? Parent { get; set; }
    public int? Index { get; set; }
    public string? Remark { get; set; }
}
