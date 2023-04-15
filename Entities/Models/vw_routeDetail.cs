using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_routeDetail
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string transportType { get; set; } = null!;

    [StringLength(50)]
    public string transportTypeDescription { get; set; } = null!;

    [StringLength(26)]
    public string carrier { get; set; } = null!;

    [StringLength(50)]
    public string? carrierDescription { get; set; }

    [StringLength(26)]
    public string state { get; set; } = null!;

    [StringLength(50)]
    public string? stateDescription { get; set; }

    [StringLength(26)]
    public string? fromCountryCode { get; set; }

    [StringLength(100)]
    public string? fromCountryName { get; set; }

    [StringLength(26)]
    public string fromCity { get; set; } = null!;

    [StringLength(50)]
    public string? cityName { get; set; }

    [StringLength(26)]
    public string fromStation { get; set; } = null!;

    [StringLength(50)]
    public string? fromStationDescription { get; set; }

    [StringLength(26)]
    public string? toCountryCode { get; set; }

    [StringLength(100)]
    public string? toCountryName { get; set; }

    [StringLength(26)]
    public string toCity { get; set; } = null!;

    [StringLength(50)]
    public string? toCityName { get; set; }

    [StringLength(26)]
    public string toStation { get; set; } = null!;

    [StringLength(50)]
    public string? toStationDescription { get; set; }

    public double distance { get; set; }

    public double duration { get; set; }

    public string? remark { get; set; }
}
