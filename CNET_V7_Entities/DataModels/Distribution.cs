using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Distribution
{
    public int Id { get; set; }

    public string? Reference { get; set; }

    public int? Index { get; set; }

    public int? Type { get; set; }

    public string? Description { get; set; }

    public int? Pointer { get; set; }

    public int? Destination { get; set; }

    public string? Remark { get; set; }

    public virtual ConsigneeUnit? DestinationNavigation { get; set; }

    public virtual SystemConstant? PointerNavigation { get; set; }

    public virtual SystemConstant? TypeNavigation { get; set; }
}
