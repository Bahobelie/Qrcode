using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class VoucherLookupList
{
    public int Id { get; set; }

    public int Voucher { get; set; }

    public int? SelectedLookup { get; set; }

    public string? Remark { get; set; }

    public virtual SystemConstant? SelectedLookupNavigation { get; set; }

    public virtual Voucher VoucherNavigation { get; set; } = null!;
}
