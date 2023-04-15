using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class IssuedCard
{
    public int Id { get; set; }

    public int Card { get; set; }

    public int? Consignee { get; set; }

    public string? Remark { get; set; }

    public virtual Card CardNavigation { get; set; } = null!;

    public virtual Consignee? ConsigneeNavigation { get; set; }
}
