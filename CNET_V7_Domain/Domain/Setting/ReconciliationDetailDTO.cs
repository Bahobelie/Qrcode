using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SettingSchema;
public partial class ReconciliationDetailDTO{
    public int Id { get; set; }
    public int ReconSum { get; set; }
    public int VoucherDefinition { get; set; }
    public bool IsDebit { get; set; }
    public string? Remark { get; set; }
}
