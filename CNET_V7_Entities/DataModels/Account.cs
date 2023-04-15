using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Account
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public int ControlAccount { get; set; }

    public string Description { get; set; } = null!;

    public bool IsActive { get; set; }

    public string? ParentAccount { get; set; }

    public string? Remark { get; set; }

    public virtual ControlAccount ControlAccountNavigation { get; set; } = null!;
}
