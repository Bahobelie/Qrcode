using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SettingSchema;
public partial class IdsettingDTO{
    public int Id { get; set; }
    public int Code { get; set; }
    public int? Reference { get; set; }
    public int? IsDefinition { get; set; }
    public int? StartFrom { get; set; }
    public bool? IsFlexible { get; set; }
    public int? Device { get; set; }
    public int? OrganizationUnit { get; set; }
    public int? CurrentValue { get; set; }
    public string? Remark { get; set; }
}
