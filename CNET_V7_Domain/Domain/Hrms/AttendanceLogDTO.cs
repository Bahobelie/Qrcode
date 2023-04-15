using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.HrmsSchema;
public partial class AttendanceLogDTO{
    public int Id { get; set; }
    public int Identification { get; set; }
    public int? MachineId { get; set; }
    public byte[]? TimeStamp { get; set; }
    public string? Remark { get; set; }
}
