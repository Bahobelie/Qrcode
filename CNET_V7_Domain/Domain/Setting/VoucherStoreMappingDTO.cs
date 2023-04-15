using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SettingSchema;
public partial class VoucherStoreMappingDTO{
    public int Id { get; set; }
    public int VoucherDefinition { get; set; }
    public int Store { get; set; }
    public bool IsSource { get; set; }
    public bool IsDefault { get; set; }
    public string? Remark { get; set; }
}
