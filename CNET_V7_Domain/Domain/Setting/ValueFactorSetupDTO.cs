using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SettingSchema;
public partial class ValueFactorSetupDTO{
    public int Id { get; set; }
    public int? ValueFactorDefinition { get; set; }
    public int? VoucherDefinition { get; set; }
    public string? Source { get; set; }
    public string? Destination { get; set; }
    public string? Remark { get; set; }
}
