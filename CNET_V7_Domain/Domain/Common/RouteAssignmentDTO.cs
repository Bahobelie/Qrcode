using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class RouteAssignmentDTO{
    public int Id { get; set; }
    public string? Description { get; set; }
    public int OrgUnit { get; set; }
    public int Space { get; set; }
    public int ScheduleHeader { get; set; }
    public string? Remark { get; set; }
}
