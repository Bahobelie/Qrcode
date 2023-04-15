using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SettingSchema;
public partial class ProgressTaxRateDTO{
    public int Id { get; set; }
    public int? TaxCode { get; set; }
    public int? Range { get; set; }
    public string? Description { get; set; }
    public decimal? Rate { get; set; }
    public decimal? Constant { get; set; }
    public string? Remark { get; set; }
}
