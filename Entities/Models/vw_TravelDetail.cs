using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_TravelDetail
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public string? name { get; set; }

    [StringLength(26)]
    public string RoomRoomDetailcode { get; set; } = null!;

    [StringLength(50)]
    public string? RoomNumber { get; set; }

    [StringLength(50)]
    public string RoomTypeDescription { get; set; } = null!;

    public string? tradeName { get; set; }

    public string actionRequired { get; set; } = null!;

    [StringLength(26)]
    public string carrier { get; set; } = null!;

    public string transactionType { get; set; } = null!;

    [StringLength(26)]
    public string? actionReqCode { get; set; }

    [StringLength(26)]
    public string transportType { get; set; } = null!;

    [StringLength(26)]
    public string fromCityCode { get; set; } = null!;

    [StringLength(26)]
    public string fromStationCode { get; set; } = null!;

    public string fromStation { get; set; } = null!;

    [StringLength(26)]
    public string toCityCode { get; set; } = null!;

    [StringLength(26)]
    public string toStationCode { get; set; } = null!;

    public string toStation { get; set; } = null!;

    [StringLength(26)]
    public string transportationNo { get; set; } = null!;

    [StringLength(26)]
    public string? travelDetailType { get; set; }

    [StringLength(26)]
    public string travelDetailCode { get; set; } = null!;

    public double? distance { get; set; }

    public double? duration { get; set; }

    [StringLength(26)]
    public string? state { get; set; }

    [StringLength(50)]
    public string fromCity { get; set; } = null!;

    [StringLength(50)]
    public string toCity { get; set; } = null!;

    [StringLength(26)]
    public string? type { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? travelTimestamp { get; set; }
}
