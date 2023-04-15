using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class VoucherConsigneeList
{
    public int Id { get; set; }

    public int Voucher { get; set; }

    public int Consignee { get; set; }

    public int? Type { get; set; }

    public string? Remark { get; set; }

    public virtual Consignee ConsigneeNavigation { get; set; } = null!;

    public virtual SystemConstant? TypeNavigation { get; set; }

    public virtual Voucher VoucherNavigation { get; set; } = null!;
}
