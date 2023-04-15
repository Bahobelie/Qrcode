using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SettingSchema;
public partial class PreferenceDTO{
    public int Id { get; set; }
    public int Code { get; set; }
    public int Pointer { get; set; }
    public int Reference { get; set; }
    public string Description { get; set; } = null!;
    public int Index { get; set; }
    public string? Font { get; set; }
    public int? Value { get; set; }
    public int? Parent { get; set; }
    public bool IsActive { get; set; }
    public string? Color { get; set; }
    public string? Remark { get; set; }
}
