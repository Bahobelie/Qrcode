using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SettingSchema;
public partial class ConfigurationDTO{
    public int Id { get; set; }
    public int? Reference { get; set; }
    public string? Attribute { get; set; }
    public string? CurrentValue { get; set; }
    public string? PreviousValue { get; set; }
    public int? Preference { get; set; }
    public string? Remark { get; set; }
}
