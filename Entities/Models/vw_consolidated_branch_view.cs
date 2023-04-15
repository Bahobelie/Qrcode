using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_consolidated_branch_view
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    [StringLength(50)]
    public string description { get; set; } = null!;

    [StringLength(50)]
    public string? specialization { get; set; }

    public string specializationDescription { get; set; } = null!;

    public double? latitude { get; set; }

    public double? longitude { get; set; }

    public string? city { get; set; }

    public string? phone { get; set; }

    public string? tin { get; set; }
}
