using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.ConsigneeSchema;
public partial class ConsigneeUserDTO{
    public int Id { get; set; }
    public int? Type { get; set; }
    public int? OwnConsignee { get; set; }
    public int? ExternalConsignee { get; set; }
    public int? ExternalConsigneeUnit { get; set; }
    public int? Role { get; set; }
    public string? Remark { get; set; }
}
