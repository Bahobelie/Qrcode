using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class CnetmediumDTO{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string StreamUrl { get; set; } = null!;
    public int Type { get; set; }
    public int Category { get; set; }
    public string? Article { get; set; }
    public int? Index { get; set; }
    public bool? Active { get; set; }
    public string? Remark { get; set; }
}
