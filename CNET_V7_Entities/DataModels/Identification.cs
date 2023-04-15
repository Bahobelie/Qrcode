using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Identification
{
    public int Id { get; set; }

    public int? Consignee { get; set; }

    public string? Description { get; set; }

    public int? Type { get; set; }

    public string? IdNumber { get; set; }

    public DateTime IssueDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string? Issuer { get; set; }

    public string? Remark { get; set; }

    public virtual ICollection<AttendanceLog> AttendanceLogs { get; } = new List<AttendanceLog>();

    public virtual Consignee? ConsigneeNavigation { get; set; }

    public virtual SystemConstant? TypeNavigation { get; set; }
}
