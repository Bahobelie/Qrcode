using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class GsluserDTO{
    public int Id { get; set; }
    public int? Article { get; set; }
    public int? ConsigneeUnit { get; set; }
    public int? Role { get; set; }
    public int? Type { get; set; }
    public string? Remark { get; set; }
}
