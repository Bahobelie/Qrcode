using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SettingSchema;
public partial class ValueFactorDefinitionDTO{
    public int Id { get; set; }
    public int Code { get; set; }
    public int? Type { get; set; }
    public string? Description { get; set; }
    public bool? IsPercent { get; set; }
    public decimal? Value { get; set; }
    public string? Remark { get; set; }
}
