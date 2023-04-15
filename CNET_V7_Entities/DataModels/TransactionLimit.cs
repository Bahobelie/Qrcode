using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class TransactionLimit
{
    public int Id { get; set; }

    public int? Consignee { get; set; }

    public string? Description { get; set; }

    public int? Type { get; set; }

    public int? LimitFactor { get; set; }

    public string? Value { get; set; }

    public string? Remark { get; set; }

    public virtual Consignee? ConsigneeNavigation { get; set; }

    public virtual SystemConstant? TypeNavigation { get; set; }
}
