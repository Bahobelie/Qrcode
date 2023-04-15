using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SettingSchema;
public partial class ObjectStateDefinitionDTO{
    public int Id { get; set; }
    public int Code { get; set; }
    public int? Type { get; set; }
    public string? Description { get; set; }
    public string? Color { get; set; }
    public int? Font { get; set; }
    public string? Remark { get; set; }
}
