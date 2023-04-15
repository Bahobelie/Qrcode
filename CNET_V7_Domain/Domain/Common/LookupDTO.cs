using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class LookupDTO{
    public int Id { get; set; }
    public int Index { get; set; }
    public string Component { get; set; } = null!;
    public string Type { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string? Value { get; set; }
    public bool IsDefault { get; set; }
    public bool IsActive { get; set; }
    public string? Remark { get; set; }
}
