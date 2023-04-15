using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vwSynchronization_view
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int GSLType { get; set; }

    [StringLength(26)]
    public string organizationUnitDefinition { get; set; } = null!;

    [StringLength(26)]
    public string type { get; set; } = null!;

    [StringLength(26)]
    public string? abbriviation { get; set; }

    [StringLength(26)]
    public string? distibutionType { get; set; }

    [StringLength(50)]
    public string distibutionDesc { get; set; } = null!;

    [StringLength(26)]
    public string? reference { get; set; }
}
