using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SettingSchema;
public partial class ReportDTO{
    public int Id { get; set; }
    public string Code { get; set; } = null!;
    public int Index { get; set; }
    public int Pointer { get; set; }
    public int Category { get; set; }
    public int ReportType { get; set; }
    public string? Reference { get; set; }
    public string DefaultName { get; set; } = null!;
    public string? CustomName { get; set; }
    public string Description { get; set; } = null!;
    public bool IsActive { get; set; }
    public string? Url { get; set; }
    public string? Remark { get; set; }
}
