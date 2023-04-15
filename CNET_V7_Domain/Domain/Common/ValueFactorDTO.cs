using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class ValueFactorDTO{
    public int Id { get; set; }
    public int Code { get; set; }
    public string? Description { get; set; }
    public int? Pointer { get; set; }
    public int? Reference { get; set; }
    public int? ValueFactorDefinition { get; set; }
    public string? Remark { get; set; }
}
