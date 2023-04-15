using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SecuritySchema;
public partial class RoleActivityDTO{
    public int Id { get; set; }
    public int Role { get; set; }
    public int ActivityDefinition { get; set; }
    public int? Range { get; set; }
    public string? Remark { get; set; }
}
