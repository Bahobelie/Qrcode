using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class RangeDTO{
    public int Id { get; set; }
    public string Description { get; set; } = null!;
    public int? Type { get; set; }
    public decimal Min { get; set; }
    public decimal Max { get; set; }
    public string? Remark { get; set; }
}
