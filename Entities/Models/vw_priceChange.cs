using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_priceChange
{
    [StringLength(26)]
    public string ArticleCode { get; set; } = null!;

    public string ArticleName { get; set; } = null!;

    [StringLength(100)]
    public string Category { get; set; } = null!;

    [StringLength(50)]
    public string oldValue { get; set; } = null!;

    [StringLength(50)]
    public string newValue { get; set; } = null!;

    [StringLength(26)]
    public string ActivityCode { get; set; } = null!;

    [StringLength(30)]
    public string? user_name { get; set; }

    public string? DeviceName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime startTimStamp { get; set; }

    [StringLength(26)]
    public string preference { get; set; } = null!;

    [StringLength(50)]
    public string? description { get; set; }

    public string PriceDescription { get; set; } = null!;
}
