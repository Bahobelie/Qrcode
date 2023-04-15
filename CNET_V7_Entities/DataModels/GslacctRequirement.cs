using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class GslacctRequirement
{
    public int Id { get; set; }

    public int ContAcct { get; set; }

    public int GslTypeList { get; set; }

    public bool IsMandatory { get; set; }

    public bool RestrictSelection { get; set; }

    public string? Remark { get; set; }

    public virtual ControlAccount ContAcctNavigation { get; set; } = null!;
}
