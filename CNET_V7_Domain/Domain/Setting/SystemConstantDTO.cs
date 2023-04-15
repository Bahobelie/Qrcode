using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SettingSchema;
public partial class SystemConstantDTO{
    public int Id { get; set; }
    public int Code { get; set; }
    public string? Type { get; set; }
    public int? Index { get; set; }
    public string? Description { get; set; }
    public string? Category { get; set; }
    public string? Value { get; set; }
    public int? ParenId { get; set; }
    public bool? IsDefault { get; set; }
    public bool? IsActive { get; set; }
    public string? Remark { get; set; }
}
