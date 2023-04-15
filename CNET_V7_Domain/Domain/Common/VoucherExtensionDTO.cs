using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class VoucherExtensionDTO{
    public int Id { get; set; }
    public int? VoucherDefn { get; set; }
    public string? Descritpion { get; set; }
    public int? Index { get; set; }
    public bool? IsMandatory { get; set; }
    public int? Type { get; set; }
    public string? Remark { get; set; }
}
