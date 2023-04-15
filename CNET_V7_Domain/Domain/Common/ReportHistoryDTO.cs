using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class ReportHistoryDTO{
    public int Id { get; set; }
    public string Report { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string? Reference { get; set; }
    public int? Period { get; set; }
    public DateTime Date { get; set; }
    public string ReportValue { get; set; } = null!;
    public string? Mtd { get; set; }
    public string? Ytd { get; set; }
    public string? Remark { get; set; }
}
