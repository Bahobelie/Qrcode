using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class ViewDeviceByReference
{
    public string name { get; set; } = null!;

    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string article { get; set; } = null!;

    [StringLength(26)]
    public string connectionType { get; set; } = null!;

    [StringLength(26)]
    public string? host { get; set; }

    [StringLength(26)]
    public string preference { get; set; } = null!;

    [StringLength(40)]
    public string? deviceValue { get; set; }

    public bool isActive { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(100)]
    public string? brand { get; set; }

    [StringLength(100)]
    public string model { get; set; } = null!;

    [StringLength(100)]
    public string? manufacturer { get; set; }

    [StringLength(25)]
    public string? size { get; set; }

    [StringLength(50)]
    public string? color { get; set; }

    [StringLength(100)]
    public string? generic { get; set; }
}
