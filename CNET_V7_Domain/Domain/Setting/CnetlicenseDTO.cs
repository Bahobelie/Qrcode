using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SettingSchema;
public partial class CnetlicenseDTO{
    public int Id { get; set; }
    public int Reference { get; set; }
    public int? Device { get; set; }
    public string LicenseCode { get; set; } = null!;
    public string? Remark { get; set; }
}
