using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class BankAccountDetail
{
    public int Id { get; set; }

    public int? Consignee { get; set; }

    public string? Description { get; set; }

    public int? Type { get; set; }

    public int? BankUnit { get; set; }

    public string? AccountNo { get; set; }

    public string? Remark { get; set; }

    public virtual ConsigneeUnit? BankUnitNavigation { get; set; }

    public virtual Consignee? ConsigneeNavigation { get; set; }

    public virtual SystemConstant? TypeNavigation { get; set; }
}
