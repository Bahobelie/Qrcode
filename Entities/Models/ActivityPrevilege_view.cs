using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class ActivityPrevilege_view
{
    [StringLength(26)]
    public string activityCode { get; set; } = null!;

    [StringLength(50)]
    public string activityDescription { get; set; } = null!;

    [StringLength(26)]
    public string? reference { get; set; }

    [StringLength(26)]
    public string? RoleActCode { get; set; }

    [StringLength(26)]
    public string? role { get; set; }

    [StringLength(26)]
    public string? activityDefinition { get; set; }

    public bool? access { get; set; }
}
