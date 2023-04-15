using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.SettingSchema;
public partial class RelationalStateDTO{
    public int Id { get; set; }
    public int Code { get; set; }
    public int? Relation { get; set; }
    public int? State { get; set; }
    public string? Criteria { get; set; }
    public string? Remark { get; set; }
}
