using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_childPrentPreferenceAccountMap
{
    [StringLength(26)]
    public string child { get; set; } = null!;

    [StringLength(26)]
    public string? parent { get; set; }

    [StringLength(26)]
    public string account { get; set; } = null!;

    [StringLength(26)]
    public string controlAccount { get; set; } = null!;
}
