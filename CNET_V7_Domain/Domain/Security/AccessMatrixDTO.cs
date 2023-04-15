using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SecuritySchema;
public partial class AccessMatrixDTO{
    public int Id { get; set; }
    public int Pointer { get; set; }
    public string Reference { get; set; } = null!;
    public int Role { get; set; }
    public string AccessLevel { get; set; } = null!;
    public string? Remark { get; set; }
}
