using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class PreferentialValueFactor
{
    public int Id { get; set; }

    public int Voucher { get; set; }

    public int? Preference { get; set; }

    public int? ValueFactorDefn { get; set; }

    public decimal? Amount { get; set; }

    public string? Remark { get; set; }

    public virtual Preference? PreferenceNavigation { get; set; }

    public virtual ValueFactorDefinition? ValueFactorDefnNavigation { get; set; }

    public virtual Voucher VoucherNavigation { get; set; } = null!;
}
