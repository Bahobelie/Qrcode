using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class ScheduleControllerMapView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(26)]
    public string cateogry { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime startDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime endDate { get; set; }

    public bool isActive { get; set; }

    [StringLength(100)]
    public string? index { get; set; }

    [StringLength(26)]
    public string facilityCode { get; set; } = null!;

    [StringLength(200)]
    public string facility { get; set; } = null!;

    [StringLength(26)]
    public string controllerCode { get; set; } = null!;

    [StringLength(26)]
    public string controllerArticle { get; set; } = null!;

    public string name { get; set; } = null!;

    [StringLength(35)]
    public string ip { get; set; } = null!;

    [StringLength(5)]
    public string? port { get; set; }
}
