using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SettingSchema;
public partial class DiscountFactorDTO{
    public int Id { get; set; }
    public string? Description { get; set; }
    public int Article { get; set; }
    public int Pointer { get; set; }
    public string Reference { get; set; } = null!;
    public int Range { get; set; }
    public int ValueFactoreDefinition { get; set; }
    public decimal Amount { get; set; }
    public bool? Category { get; set; }
    public string? Remark { get; set; }
}
