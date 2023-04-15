using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class ClosedRelation
{
    public int Id { get; set; }

    public int Voucher { get; set; }

    public DateTime TimeStamp { get; set; }

    public int ReferredVouherDefn { get; set; }

    public int ReferringVoucherDefn { get; set; }

    public string? Remark { get; set; }

    public virtual SystemConstant ReferredVouherDefnNavigation { get; set; } = null!;

    public virtual SystemConstant ReferringVoucherDefnNavigation { get; set; } = null!;

    public virtual Voucher VoucherNavigation { get; set; } = null!;
}
