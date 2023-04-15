using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class ConsigneeUser
{
    public int Id { get; set; }

    public int? Type { get; set; }

    public int? OwnConsignee { get; set; }

    public int? ExternalConsignee { get; set; }

    public int? ExternalConsigneeUnit { get; set; }

    public int? Role { get; set; }

    public string? Remark { get; set; }

    public virtual Consignee? ExternalConsigneeNavigation { get; set; }

    public virtual ConsigneeUnit? ExternalConsigneeUnitNavigation { get; set; }

    public virtual Consignee? OwnConsigneeNavigation { get; set; }

    public virtual SystemConstant? TypeNavigation { get; set; }
}
