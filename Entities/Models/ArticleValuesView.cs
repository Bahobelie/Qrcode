using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class ArticleValuesView
{
    [StringLength(26)]
    public string code { get; set; } = null!;

    public int? gslType { get; set; }

    [StringLength(26)]
    public string reference { get; set; } = null!;

    [StringLength(26)]
    public string? SpaceId { get; set; }

    [StringLength(26)]
    public string? type { get; set; }

    [StringLength(100)]
    public string? remark { get; set; }

    [StringLength(81)]
    public string? LifeTimes { get; set; }
}
