using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class SeasonalMessageDTO{
    public int Id { get; set; }
    public string Message { get; set; } = null!;
    public int Period { get; set; }
    public string? Font { get; set; }
    public string? Remark { get; set; }
}
