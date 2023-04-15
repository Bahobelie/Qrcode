using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SettingSchema;
public partial class RequiredGsldetailDTO{
    public int Id { get; set; }
    public int? RequiredGsl { get; set; }
    public int? GslType { get; set; }
    public int? ObjectState { get; set; }
    public int? Index { get; set; }
    public string? Remark { get; set; }
}
