using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class AccessControlView
{
    public string DeviceName { get; set; } = null!;

    [StringLength(200)]
    public string Facility { get; set; } = null!;

    [StringLength(26)]
    public string? device { get; set; }

    [StringLength(35)]
    public string? ip { get; set; }

    [StringLength(5)]
    public string? port { get; set; }

    [StringLength(26)]
    public string? host { get; set; }

    [StringLength(26)]
    public string connectionType { get; set; } = null!;

    [StringLength(26)]
    public string PrefCode { get; set; } = null!;

    [StringLength(100)]
    public string? model { get; set; }

    [StringLength(26)]
    public string spaceCode { get; set; } = null!;

    [StringLength(26)]
    public string? type { get; set; }

    [StringLength(40)]
    public string? deviceValue { get; set; }
}
