using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class SubCountryDTO{
    public int Id { get; set; }
    public int Country { get; set; }
    public string Name { get; set; } = null!;
    public string? AlternativeName { get; set; }
    public int? Type { get; set; }
    public string? Gps { get; set; }
    public string? Parent { get; set; }
    public int? Population { get; set; }
    public string? Remark { get; set; }
}
