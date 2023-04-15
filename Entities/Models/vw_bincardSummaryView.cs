using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_bincardSummaryView
{
    [StringLength(26)]
    public string articlecode { get; set; } = null!;

    public string? articleName { get; set; }

    public int? gslType { get; set; }

    [StringLength(26)]
    public string? store { get; set; }

    [Column(TypeName = "decimal(38, 7)")]
    public decimal? beg { get; set; }

    [Column(TypeName = "decimal(38, 0)")]
    public decimal? totalin { get; set; }

    [Column(TypeName = "decimal(38, 0)")]
    public decimal? totalout { get; set; }

    [Column(TypeName = "decimal(38, 7)")]
    public decimal? balance { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? last_period { get; set; }

    public string? org { get; set; }
}
