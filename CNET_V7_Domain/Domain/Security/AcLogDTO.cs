using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SecuritySchema;
public partial class AcLogDTO{
    public int Id { get; set; }
    public int Code { get; set; }
    public int Card { get; set; }
    public int? AcDevice { get; set; }
    public string? Reader { get; set; }
    public string Description { get; set; } = null!;
    public DateTime TimeStamp { get; set; }
    public int Year { get; set; }
    public int Month { get; set; }
    public int Date { get; set; }
    public bool IsEntry { get; set; }
    public bool? IsClosed { get; set; }
    public bool IsGranted { get; set; }
    public string? Remark { get; set; }
}
