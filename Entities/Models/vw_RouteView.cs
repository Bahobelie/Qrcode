using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_RouteView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string transportTypeCode { get; set; } = null!;

    [StringLength(50)]
    public string transportType { get; set; } = null!;

    [StringLength(26)]
    public string carrierCode { get; set; } = null!;

    [StringLength(50)]
    public string carrier { get; set; } = null!;

    [StringLength(26)]
    public string fromStationCode { get; set; } = null!;

    [StringLength(50)]
    public string fromStation { get; set; } = null!;

    [StringLength(26)]
    public string toStationCode { get; set; } = null!;

    [StringLength(50)]
    public string toStation { get; set; } = null!;

    [StringLength(26)]
    public string fromCityCode { get; set; } = null!;

    [StringLength(50)]
    public string fromCity { get; set; } = null!;

    [StringLength(26)]
    public string toCityCode { get; set; } = null!;

    [StringLength(50)]
    public string toCity { get; set; } = null!;

    public double? distance { get; set; }

    public double? duration { get; set; }
}
