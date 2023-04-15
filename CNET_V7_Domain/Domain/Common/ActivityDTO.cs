using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class ActivityDTO{
    public int Id { get; set; }
    public int? Pointer { get; set; }
    public string Reference { get; set; } = null!;
    public int? ActivityDefinition { get; set; }
    public DateTime? TimeStamp { get; set; }
    public int? Period { get; set; }
    public int? ConsigneeUnit { get; set; }
    public int? Device { get; set; }
    public string? Platform { get; set; }
    public string? IpAdress { get; set; }
    public int? User { get; set; }
    public decimal? Longitude { get; set; }
    public decimal? Latitude { get; set; }
    public int? Date { get; set; }
    public int? Month { get; set; }
    public int? Year { get; set; }
    public string? Remark { get; set; }
}
