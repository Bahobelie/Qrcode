using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class LanguageDTO{
    public int Id { get; set; }
    public string Description { get; set; } = null!;
    public int Type { get; set; }
    public int Pointer { get; set; }
    public string Reference { get; set; } = null!;
    public string? Remark { get; set; }
}
