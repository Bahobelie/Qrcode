using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SettingSchema;
public partial class ReconciliationSummaryDTO{
    public int Id { get; set; }
    public string Code { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int Comparision { get; set; }
    public int ComparisionType { get; set; }
    public string? Remark { get; set; }
}
