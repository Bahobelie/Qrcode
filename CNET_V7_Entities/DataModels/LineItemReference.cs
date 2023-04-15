using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class LineItemReference
{
    public int Id { get; set; }

    public int LineItem { get; set; }

    public int? Voucher { get; set; }

    public int? ReferencedVouDfn { get; set; }

    public int? Referenced { get; set; }

    public decimal? Value { get; set; }

    public string? Remark { get; set; }

    public virtual LineItem LineItemNavigation { get; set; } = null!;

    public virtual LineItem? ReferencedNavigation { get; set; }

    public virtual SystemConstant? ReferencedVouDfnNavigation { get; set; }

    public virtual Voucher? VoucherNavigation { get; set; }
}
