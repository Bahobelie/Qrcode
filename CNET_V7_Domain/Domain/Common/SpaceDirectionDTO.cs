using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class SpaceDirectionDTO{
    public int Id { get; set; }
    public int Device { get; set; }
    public int Space { get; set; }
    public string Direction { get; set; } = null!;
    public string? Remark { get; set; }
}
