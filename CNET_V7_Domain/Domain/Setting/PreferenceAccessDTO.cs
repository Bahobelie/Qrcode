using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SettingSchema;
public partial class PreferenceAccessDTO{
    public int Id { get; set; }
    public string Description { get; set; } = null!;
    public int VoucherDfn { get; set; }
    public int Preference { get; set; }
    public int Device { get; set; }
    public string? Remark { get; set; }
}
