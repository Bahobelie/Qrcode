using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SecuritySchema;
public partial class UserRoleMapperDTO{
    public int Id { get; set; }
    public int Role { get; set; }
    public int User { get; set; }
    public DateTime ExpiryDate { get; set; }
    public string? Remark { get; set; }
}
