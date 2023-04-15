using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class DeviceView
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

    public bool isActive { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }
}
