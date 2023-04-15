using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class SubscriptionControllerMapView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime IssuedDate { get; set; }

    [StringLength(26)]
    public string? consignee { get; set; }

    public string? consigneeName { get; set; }

    [StringLength(26)]
    public string card { get; set; } = null!;

    [StringLength(100)]
    public string? CardIndex { get; set; }

    public int? PIN { get; set; }

    [StringLength(26)]
    public string? CardStatusCode { get; set; }

    public string CardStatus { get; set; } = null!;

    [StringLength(26)]
    public string ServiceCode { get; set; } = null!;

    public string ServiceName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime expiryDate { get; set; }

    [StringLength(26)]
    public string FacilityCode { get; set; } = null!;

    [StringLength(200)]
    public string Facility { get; set; } = null!;

    [StringLength(26)]
    public string ControllerCode { get; set; } = null!;

    public string ControllerName { get; set; } = null!;

    [StringLength(35)]
    public string ip { get; set; } = null!;

    [StringLength(5)]
    public string? port { get; set; }

    [StringLength(100)]
    public string timeZone { get; set; } = null!;

    [StringLength(50)]
    public string? description { get; set; }

    [StringLength(26)]
    public string? color { get; set; }

    [StringLength(26)]
    public string? userCode { get; set; }

    [StringLength(30)]
    public string? userName { get; set; }

    [StringLength(26)]
    public string? deviceCode { get; set; }

    public string? deviceName { get; set; }
}
