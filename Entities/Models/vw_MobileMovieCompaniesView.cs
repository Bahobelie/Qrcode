using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_MobileMovieCompaniesView
{
    public string tradeName { get; set; } = null!;

    public string? brandName { get; set; }

    [StringLength(26)]
    public string orgUnit { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime startDate { get; set; }

    [StringLength(50)]
    public string branchName { get; set; } = null!;

    public double? longitude { get; set; }

    public double? latitude { get; set; }

    public string? addressValue { get; set; }

    [StringLength(256)]
    public string? logoUrl { get; set; }
}
