using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class DenominationDTO{
    public int Id { get; set; }
    public int Code { get; set; }
    public int Currency { get; set; }
    public string Description { get; set; } = null!;
    public decimal Weight { get; set; }
    public string Type { get; set; } = null!;
    public string? Remark { get; set; }
}
