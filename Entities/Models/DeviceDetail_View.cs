using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class DeviceDetail_View
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(26)]
    public string devArtCode { get; set; } = null!;

    [StringLength(40)]
    public string deviceName { get; set; } = null!;

    [StringLength(50)]
    public string? devicePreference { get; set; }

    [StringLength(26)]
    public string? hosDevCode { get; set; }

    [StringLength(26)]
    public string? hosArtCode { get; set; }

    [StringLength(40)]
    public string? hostName { get; set; }

    [StringLength(50)]
    public string ConnectionType { get; set; } = null!;

    public bool isActive { get; set; }
}
