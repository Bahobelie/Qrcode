using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SettingSchema;
public partial class TaxDTO{
    public int Id { get; set; }
    public int Code { get; set; }
    public int? Category { get; set; }
    public string? Description { get; set; }
    public double? Amount { get; set; }
    public string? Remark { get; set; }
}
