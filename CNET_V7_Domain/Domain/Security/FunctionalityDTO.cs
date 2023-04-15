using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SecuritySchema;
public partial class FunctionalityDTO{
    public int Id { get; set; }
    public int VisualComponent { get; set; }
    public int SubSystemComponent { get; set; }
    public string Description { get; set; } = null!;
    public int Category { get; set; }
    public string Function { get; set; } = null!;
    public string? Remark { get; set; }
}
