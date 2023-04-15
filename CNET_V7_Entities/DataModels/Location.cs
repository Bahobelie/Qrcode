using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Location
{
    public int Id { get; set; }

    public int? Type { get; set; }

    public int? GslType { get; set; }

    public int? Reference { get; set; }

    public int? Space { get; set; }

    public string? Remark { get; set; }

    public virtual SystemConstant? GslTypeNavigation { get; set; }

    public virtual Space? SpaceNavigation { get; set; }

    public virtual SystemConstant? TypeNavigation { get; set; }
}
