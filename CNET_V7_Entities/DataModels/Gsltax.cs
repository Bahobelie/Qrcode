using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Gsltax
{
    public int Id { get; set; }

    public int Code { get; set; }

    public int Reference { get; set; }

    public int Tax { get; set; }

    public string? Remark { get; set; }

    public virtual Tax TaxNavigation { get; set; } = null!;
}
