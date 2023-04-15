using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class HolidayDefinitionDTO{
    public int Id { get; set; }
    public string Description { get; set; } = null!;
    public string Type { get; set; } = null!;
    public bool IsFixed { get; set; }
    public bool WillClose { get; set; }
    public int? AlertBefore { get; set; }
    public string? Remark { get; set; }
}
