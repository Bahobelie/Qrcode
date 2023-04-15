using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_RoomFeature
{
    [StringLength(75)]
    public string lookupType { get; set; } = null!;

    [StringLength(50)]
    public string featureDescription { get; set; } = null!;

    [StringLength(40)]
    public string? lookupValue { get; set; }

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string feature { get; set; } = null!;

    [StringLength(50)]
    public string roomTypeDescription { get; set; } = null!;

    public bool isActive { get; set; }

    [StringLength(26)]
    public string? roomClass { get; set; }
}
