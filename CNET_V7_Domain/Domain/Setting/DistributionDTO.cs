using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SettingSchema;
public partial class DistributionDTO{
    public int Id { get; set; }
    public string? Reference { get; set; }
    public int? Index { get; set; }
    public int? Type { get; set; }
    public string? Description { get; set; }
    public int? Pointer { get; set; }
    public int? Destination { get; set; }
    public string? Remark { get; set; }
}
