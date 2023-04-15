using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities.Models;

[Keyless]
public partial class vw_ArticleCBView
{
    [StringLength(26)]
    public string ArticleCode { get; set; } = null!;

    public string ArticleName { get; set; } = null!;

    [StringLength(26)]
    public string preferenceCode { get; set; } = null!;

    [StringLength(50)]
    public string? PreferenceDescription { get; set; }

    [StringLength(15)]
    public string uom { get; set; } = null!;

    [StringLength(50)]
    public string? uomDescription { get; set; }

    [Column(TypeName = "money")]
    public decimal? priceValue { get; set; }

    [StringLength(25)]
    public string? size { get; set; }

    [StringLength(50)]
    public string? ProductColor { get; set; }
}
