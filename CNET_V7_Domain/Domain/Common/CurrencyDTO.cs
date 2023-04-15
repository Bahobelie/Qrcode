using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class CurrencyDTO{
    public int Id { get; set; }
    public int Code { get; set; }
    public int? Country { get; set; }
    public string? Description { get; set; }
    public string? Sign { get; set; }
    public string? Abbrivation { get; set; }
    public bool? IsDefault { get; set; }
    public string? Remark { get; set; }
}
