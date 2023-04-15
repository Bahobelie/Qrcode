using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class PreferenceAccess
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int VoucherDfn { get; set; }

    public int Preference { get; set; }

    public int Device { get; set; }

    public string? Remark { get; set; }

    public virtual Device DeviceNavigation { get; set; } = null!;

    public virtual Preference PreferenceNavigation { get; set; } = null!;

    public virtual SystemConstant VoucherDfnNavigation { get; set; } = null!;
}
