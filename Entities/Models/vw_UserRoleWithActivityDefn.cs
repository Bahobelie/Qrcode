using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_UserRoleWithActivityDefn
{
    [StringLength(26)]
    public string userId { get; set; } = null!;

    [StringLength(26)]
    public string person { get; set; } = null!;

    [StringLength(30)]
    public string userName { get; set; } = null!;

    [StringLength(26)]
    public string role { get; set; } = null!;

    [StringLength(26)]
    public string activityDefinition { get; set; } = null!;

    [StringLength(26)]
    public string? component { get; set; }

    [StringLength(26)]
    public string? reference { get; set; }

    [StringLength(50)]
    public string ADdescription { get; set; } = null!;
}
