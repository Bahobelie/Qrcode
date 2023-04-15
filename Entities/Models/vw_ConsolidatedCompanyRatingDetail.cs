using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ConsolidatedCompanyRatingDetail
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public string tradeName { get; set; } = null!;

    public string? brandName { get; set; }

    [StringLength(26)]
    public string industry { get; set; } = null!;

    public string TIN { get; set; } = null!;

    [StringLength(256)]
    public string? url { get; set; }

    public string connectionString { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string note { get; set; } = null!;

    public int? ratingCount { get; set; }

    [Column(TypeName = "money")]
    public decimal? rating { get; set; }
}
