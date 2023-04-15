using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class ObjectStateDTO{
    public int Id { get; set; }
    public int Code { get; set; }
    public int? Reference { get; set; }
    public int? ObjectStateDefinition { get; set; }
    public string? Remark { get; set; }
}
