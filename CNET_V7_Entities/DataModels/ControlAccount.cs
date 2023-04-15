using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class ControlAccount
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public string NormalBalance { get; set; } = null!;

    public string AccCategory { get; set; } = null!;

    public string AccType { get; set; } = null!;

    public string? Remark { get; set; }

    public virtual ICollection<Account> Accounts { get; } = new List<Account>();

    public virtual ICollection<GslacctRequirement> GslacctRequirements { get; } = new List<GslacctRequirement>();
}
