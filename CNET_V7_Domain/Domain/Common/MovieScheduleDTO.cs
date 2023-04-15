using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class MovieScheduleDTO{
    public int Id { get; set; }
    public int OrgUnit { get; set; }
    public int Reference { get; set; }
    public int Space { get; set; }
    public int ScheduleHeader { get; set; }
    public int? Dimension { get; set; }
    public decimal Value { get; set; }
    public string? Remark { get; set; }
}
