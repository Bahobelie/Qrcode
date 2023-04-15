using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SettingSchema;
public partial class ActivityDefinitionDTO{
    public int Id { get; set; }
    public int? Componet { get; set; }
    public int? Reference { get; set; }
    public int Description { get; set; }
    public int Index { get; set; }
    public bool? NeedsPassCode { get; set; }
    public bool IssuingEffect { get; set; }
    public bool IsManual { get; set; }
    public string? TimeFactor { get; set; }
    public double? RequiredTime { get; set; }
    public int? MaxRepeat { get; set; }
    public bool? Sequence { get; set; }
    public string? Remark { get; set; }
}
