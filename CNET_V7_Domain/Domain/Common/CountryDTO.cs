using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class CountryDTO{
    public int Id { get; set; }
    public int Code { get; set; }
    public string? Name { get; set; }
    public string? PoliticalName { get; set; }
    public int? Continent { get; set; }
    public string? TelephoneCode { get; set; }
    public string? TimeZone { get; set; }
    public string? Nationality { get; set; }
    public string? IcaocountryCode { get; set; }
    public string? Remark { get; set; }
}
