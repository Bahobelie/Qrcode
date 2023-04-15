using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ArticleBeginningView
{
    [StringLength(26)]
    public string ArticleCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? value { get; set; }

    [Column(TypeName = "decimal(38, 7)")]
    public decimal? quantity { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime start { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime end { get; set; }

    [StringLength(26)]
    public string PeriodId { get; set; } = null!;
}
