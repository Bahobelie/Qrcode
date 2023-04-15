using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class LocationDTO{
    public int Id { get; set; }
    public int? Type { get; set; }
    public int? GslType { get; set; }
    public int? Reference { get; set; }
    public int? Space { get; set; }
    public string? Remark { get; set; }
}
