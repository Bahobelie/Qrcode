using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SettingSchema;
public partial class TermDefinitionDTO{
    public int Id { get; set; }
    public int? VoucherDefn { get; set; }
    public int? Category { get; set; }
    public string? Description { get; set; }
    public string? DefaultValue { get; set; }
    public bool? IsMandatory { get; set; }
    public string? Remark { get; set; }
}
