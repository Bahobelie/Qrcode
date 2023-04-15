using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class AccountMap
{
    public int Id { get; set; }

    public string Reference { get; set; } = null!;

    public int ConsigneeUnit { get; set; }

    public string? Description { get; set; }

    public string Account { get; set; } = null!;

    public string? Remark { get; set; }
}
