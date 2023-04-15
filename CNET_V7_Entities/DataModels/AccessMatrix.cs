using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class AccessMatrix
{
    public int Id { get; set; }

    public int Pointer { get; set; }

    public string Reference { get; set; } = null!;

    public int Role { get; set; }

    public string AccessLevel { get; set; } = null!;

    public string? Remark { get; set; }

    public virtual SystemConstant PointerNavigation { get; set; } = null!;

    public virtual ConsigneeUnit RoleNavigation { get; set; } = null!;
}
