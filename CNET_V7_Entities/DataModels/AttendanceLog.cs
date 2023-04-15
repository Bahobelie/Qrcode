using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class AttendanceLog
{
    public int Id { get; set; }

    public int Identification { get; set; }

    public int? MachineId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public string? Remark { get; set; }

    public virtual Identification IdentificationNavigation { get; set; } = null!;

    public virtual Device? Machine { get; set; }
}
