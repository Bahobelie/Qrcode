using System;
using System.Collections.Generic;

namespace CNET_V7_Entities.DataModels;

public partial class Cnetlicense
{
    public int Id { get; set; }

    public int Reference { get; set; }

    public int? Device { get; set; }

    public string LicenseCode { get; set; } = null!;

    public string? Remark { get; set; }

    public virtual Device? DeviceNavigation { get; set; }

    public virtual SystemConstant ReferenceNavigation { get; set; } = null!;
}
