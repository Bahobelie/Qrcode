using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class ArticleBeginningStockView
{
    public string name { get; set; } = null!;

    public int gslType { get; set; }

    [StringLength(26)]
    public string preference { get; set; } = null!;

    [StringLength(26)]
    public string code { get; set; } = null!;

    [Column(TypeName = "decimal(18, 7)")]
    public decimal? quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal? value { get; set; }

    [StringLength(50)]
    public string? beginningType { get; set; }

    [StringLength(100)]
    public string? batch { get; set; }

    [StringLength(26)]
    public string? store { get; set; }

    [StringLength(26)]
    public string? stockType { get; set; }

    [StringLength(26)]
    public string? stockPeriod { get; set; }

    [StringLength(26)]
    public string? beginningPeriod { get; set; }
}
