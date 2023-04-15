using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class GetAllOrderStationMapView
{
    [StringLength(35)]
    public string ip { get; set; } = null!;

    [StringLength(26)]
    public string preference { get; set; } = null!;

    [StringLength(26)]
    public string posDevice { get; set; } = null!;

    public string name { get; set; } = null!;

    [StringLength(26)]
    public string stationDevice { get; set; } = null!;

    [StringLength(100)]
    public string model { get; set; } = null!;

    [StringLength(26)]
    public string connectionType { get; set; } = null!;

    [StringLength(26)]
    public string? host { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    public string? hostName { get; set; }
}
