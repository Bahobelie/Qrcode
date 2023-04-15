using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_TravelDetailView
{
    [StringLength(26)]
    public string? voucher { get; set; }

    [StringLength(26)]
    public string? route { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? travelDate { get; set; }

    [StringLength(50)]
    public string carrier { get; set; } = null!;

    [StringLength(26)]
    public string transportType { get; set; } = null!;

    [StringLength(26)]
    public string fromCityCode { get; set; } = null!;

    [StringLength(26)]
    public string fromStationCode { get; set; } = null!;

    [StringLength(50)]
    public string fromCity { get; set; } = null!;

    [StringLength(50)]
    public string fromStation { get; set; } = null!;

    [StringLength(26)]
    public string toCityCode { get; set; } = null!;

    [StringLength(26)]
    public string toStationCode { get; set; } = null!;

    [StringLength(50)]
    public string toCity { get; set; } = null!;

    [StringLength(50)]
    public string toStation { get; set; } = null!;

    [StringLength(50)]
    public string transactionType { get; set; } = null!;

    public double? distance { get; set; }

    public double? duration { get; set; }

    [StringLength(26)]
    public string carrierCode { get; set; } = null!;

    [StringLength(26)]
    public string? actionRequiredCode { get; set; }

    [StringLength(50)]
    public string? actionRequired { get; set; }
}
