using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class VoucherAccount
{
    public int Id { get; set; }

    public int Voucher { get; set; }

    public string AccountCode { get; set; } = null!;

    public decimal? Amount { get; set; }

    public string? Remark { get; set; }

    public virtual Voucher VoucherNavigation { get; set; } = null!;
}
