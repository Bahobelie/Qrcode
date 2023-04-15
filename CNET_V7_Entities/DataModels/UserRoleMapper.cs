using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class UserRoleMapper
{
    public int Id { get; set; }

    public int Role { get; set; }

    public int User { get; set; }

    public DateTime ExpiryDate { get; set; }

    public string? Remark { get; set; }

    public virtual ConsigneeUnit RoleNavigation { get; set; } = null!;

    public virtual User UserNavigation { get; set; } = null!;
}
