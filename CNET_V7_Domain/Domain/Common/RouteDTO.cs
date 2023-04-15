using System;
using System.Collections.Generic;
namespace CNET_V7_Domain.DataModels.CommonSchema;
public partial class RouteDTO{
    public int Id { get; set; }
    public int TransportType { get; set; }
    public string? Carrier { get; set; }
    public int? ObjectState { get; set; }
    public int FromCity { get; set; }
    public int FromStation { get; set; }
    public int ToCity { get; set; }
    public int ToStation { get; set; }
    public decimal? Distance { get; set; }
    public decimal? Duration { get; set; }
    public string? Remark { get; set; }
}
